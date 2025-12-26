using ProtoBuf;
using SmartCodeLab.CustomComponents.CustomDialogs.StudentTable;
using SmartCodeLab.CustomComponents.Pages.ServerPages;
using SmartCodeLab.CustomComponents.ServerPageComponents;
using SmartCodeLab.CustomComponents.WPFComponents;
using SmartCodeLab.Models;
using SmartCodeLab.Models.Enums;
using SmartCodeLab.Services;
using SmartCodeLab.Services.ModelServices;
using System.Collections.Concurrent;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms.Integration;

namespace SmartCodeLab.CustomComponents.Pages
{
    public partial class MainServerPage2 : UserControl
    {
        private Server server;
        //controls handling and pages
        private TempServerPage serverPage;  
        private StudTable userTable;
        private ServerHomePage homePage;
        private ProgressSubmissionPage progressSubmissionPage;

        //network and user connectivity related
        //private readonly MessageType[] ForMainServer = { MessageType.UserProfile };//messages that are meant for this page, or class
        private TaskModel currentTask;
        private TcpListener serverListener;

        //users related
        private ConcurrentDictionary<string, TcpClient> connectedUsers;
        private ConcurrentDictionary<string, bool> currentStudents = new ConcurrentDictionary<string, bool>();
        //will use userId as a KEY
        private ConcurrentDictionary<string, StudentCodingProgress> userProgress;

        private ConcurrentDictionary<string, UserProfile> users;
        private bool isStillActive;
        public MainServerPage2(Server server)
        {
            InitializeComponent();
            SessionNavigationMenu();
            isStillActive = true;
            this.server = server;
            serverListener = new TcpListener(IPAddress.Any, 1901);
            currentTask = server.ServerTask;
            Task.Run(async () => await StartServerAsync());
            connectedUsers = new ConcurrentDictionary<string, TcpClient>(
                concurrencyLevel: 64,       // For 30+ concurrent connections
                capacity: 50                // Expected max simultaneous connections
            );

            // Student progress tracking
            userProgress = new ConcurrentDictionary<string, StudentCodingProgress>(
                concurrencyLevel: 64,       // Same as above for consistency
                capacity: 100               // All 50 students + room for more
            );

            // User profiles (loaded from server)
            users = new ConcurrentDictionary<string, UserProfile>(
                concurrencyLevel: 64,
                capacity: 150
            );

            // Then add all users
            foreach (var kvp in server.Users)
            {
                users.TryAdd(kvp.Key, kvp.Value);
            }
            serverPage = new TempServerPage(server.ServerTask, server.Users, IdStudentProgress, isConnected, sendStudentMessage, UpdateMonitorStatus);

            SystemSingleton.Instance.saveSession = saveSession;
            homePage = new ServerHomePage(server, displayStudentTable, saveSession, closeServer);
            homePage._totalStudents = server.Users.Count;
            progressSubmissionPage = new ProgressSubmissionPage();
            progressSubmissionPage.ratingFactorsWeight = currentTask.ratingFactors;
            progressSubmissionPage.setTheStats();
            progressSubmissionPage.leaderboardsUpdate = UpdateServerTask;
            progressSubmissionPage.progressGetter = IdStudentProgress;
            var taskUpdatePage = new ServerTaskUpdate(currentTask, UpdateServerTask);

            homePage.Dock = DockStyle.Fill;
            serverPage.Dock = DockStyle.Fill;
            taskUpdatePage.Dock = DockStyle.Fill;
            progressSubmissionPage.Dock = DockStyle.Fill;

            tabPage1.Controls.Add(homePage);
            tabPage2.Controls.Add(serverPage);
            tabPage3.Controls.Add(taskUpdatePage);
            tabPage4.Controls.Add(progressSubmissionPage);
        }

        private void displayStudentTable()
        {
            userTable = new StudTable(users.ToDictionary(kvp => kvp.Key, kvp => kvp.Value), serverPage.displayUsers, studentChangesDisplayUpdate, NotifyStudent);
            userTable.ShowDialog();
            users = new ConcurrentDictionary<string, UserProfile>(userTable.expectedUsers);
            server.Users = users.ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            homePage.updateCountDisplay(users.Count);
        }

        private async void studentChangesDisplayUpdate(UserProfile user, bool isUpdate)
        {
            if (user == null)
                return;

            if (isUpdate)
            {
                homePage?.updateNotifCardName(user);
                serverPage.updateUserProfile(user);
            }
            else 
            {
                _ = serverPage.removeUserIcon(user._studentId);
                _ = NotifyStudent(new ServerMessage.Builder(MessageType.KICKED).Build(), user._studentId);
            }
        }

        public async Task<bool> sendStudentMessage(string studentId, UserMessage message)
        {
            if (connectedUsers.ContainsKey(studentId))
            {
                NetworkStream stream = connectedUsers[studentId].GetStream();
                Serializer.SerializeWithLengthPrefix<ServerMessage>(stream,
                    new ServerMessage.Builder(MessageType.USER_MESSAGE).UserMessage(message).Build(), PrefixStyle.Base128);
                await stream.FlushAsync();
                return true;
            }
            else
            {
                NonBlockingNotification("Student is not connected.");
                return false;
            }
        }

        //will be used for operations that will send a ServerMessage to the student
        public async Task NotifyStudent(ServerMessage serverMessage, string userId)
        {
            if (connectedUsers.ContainsKey(userId))
            {
                MessageType messageType = serverMessage._messageType;
                NetworkStream stream = connectedUsers[userId].GetStream();
                Serializer.SerializeWithLengthPrefix<ServerMessage>(stream, serverMessage, PrefixStyle.Base128);
                await stream.FlushAsync();

                if(serverMessage._messageType == MessageType.KICKED)
                    NonBlockingNotification("Student Successfully Kicked.");
            }
        }

        public async void UpdateMonitorStatus(string userId, bool isMonitored)
        {
            if (connectedUsers.ContainsKey(userId))
            {
                await NotifyStudent(new ServerMessage.Builder(isMonitored ? MessageType.MONITORED : MessageType.LEFT_ALONE).Build(), userId);
            }
        }

        private bool isConnected(string studentId)
        {
            return connectedUsers.ContainsKey(studentId);
        }

        private void SessionNavigationMenu()
        {
            // 1. Guard clause at the top
            if (panelNavHost2 == null)
            {
                return;
            }

            // 2. Calculate and set the panel's new, scaled height
            float dpiScale;
            using (Graphics g = this.CreateGraphics())
            {
                // Gets the system scale (e.g., 1.25 for 125%)
                dpiScale = g.DpiX / 96f;
            }

            // Gets your designer height (e.g., 46) and sets the new runtime height (e.g., 58)
            panelNavHost2.Height = (int)(panelNavHost2.Height * dpiScale);

            var navMenu = new SessionNavbar();

            navMenu.OnNavigationClicked = (tabIndex) =>
            {
                if (container != null) // Guard clause
                {
                    container.SuspendLayout();

                    try 
                    {
                        container.SelectedIndex = tabIndex;
                    
                    } finally { 

                        container.ResumeLayout(true);
                    }
                }
            };

            var host = new ElementHost
            {
                Dock = DockStyle.Fill,
                Child = navMenu
            };


            if (panelNavHost2 != null)
            {
                panelNavHost2.Controls.Add(host);
            }

        }
        //network related stuffs
        UdpClient udpServer;
        private async Task UdpServerInfoSender()
        {
            udpServer = new UdpClient(new IPEndPoint(IPAddress.Any, 1902));

            while (isStillActive)
            {
                var result = await udpServer.ReceiveAsync();
                byte[] taskData = Encoding.UTF8.GetBytes(JsonFileService.GetObjectJsonText(server));
                udpServer.Send(taskData, taskData.Length, result.RemoteEndPoint);
            }
            udpServer.Close();
        }

        private async Task StartServerAsync()
        {
            try
            {
                serverListener.Start(); // Only start once!
                _ = UdpServerInfoSender();
                while (isStillActive)
                {
                    TcpClient client = await AcceptTcpClientAsync(serverListener);

                    // Handle each client in a separate task
                    _ = Task.Run(() => MessageReceiverAsync(client));
                }
                serverListener.Dispose();
            }
            catch (Exception ex)
            {
            }
        }

        private async void closeServer()
        {
            //tell all students goodbye T_T
            foreach (var user in connectedUsers)
            {
                await NotifyStudent(new ServerMessage.Builder(MessageType.SERVER_SHUTDOWN).Build(), user.Key);
            }
            saveSession();
            isStillActive = false;
            serverListener.Stop();
            udpServer.Close();
        }
        private Task<TcpClient> AcceptTcpClientAsync(TcpListener listener)
        {
            return Task.Run(() => listener.AcceptTcpClient());
        }

        private async Task MessageReceiverAsync(TcpClient client)
        {
            NetworkStream networkStream = client.GetStream();
            UserProfile userProfile = new UserProfile();
            bool didLoggedIn = false;
            //send the task to the new client
            Serializer.SerializeWithLengthPrefix<ServerMessage>(networkStream, new ServerMessage.Builder(MessageType.SERVER_TASK).Task(currentTask).Build(), PrefixStyle.Base128);
            await networkStream.FlushAsync();
            while (isStillActive)
            {
                try
                {
                    ServerMessage obj;
                    try
                    {
                        obj = Serializer.DeserializeWithLengthPrefix<ServerMessage>(networkStream, PrefixStyle.Base128);
                    }
                    catch (IOException)
                    {
                        break;
                    }
                    if (obj == null)
                        break;

                    switch (obj._messageType)
                    {
                        case MessageType.SERVER_TASK_REQUEST:
                            Serializer.SerializeWithLengthPrefix<ServerMessage>(networkStream,
                                new ServerMessage.Builder(MessageType.SERVER_TASK).Task(currentTask).Build(), PrefixStyle.Base128);
                            await networkStream.FlushAsync();
                            break;
                        case MessageType.USER_PROFILE:
                            if (obj._userProfile == null)
                                break;
                            //the obj._userProfile only contains userId/studentId
                            userProfile = obj._userProfile;
                            didLoggedIn = false;
                            string errorMsg = "We can't find an account with that Student ID";
                            if (users.ContainsKey(userProfile._studentId))
                            {
                                //will retrieve the full student profile from the table using studentId
                                userProfile = users[userProfile._studentId];
                                if (currentStudents.ContainsKey(userProfile._studentName))
                                {
                                    errorMsg = "This student is already logged in";
                                }
                                else if (obj._userProfile._password != server.Password)
                                {
                                    errorMsg = "Incorrect Password";
                                }
                                else
                                {
                                    var progress = userProgress.GetOrAdd(userProfile._studentId, key => new StudentCodingProgress());
                                    currentStudents.TryAdd(userProfile._studentName, true);
                                    Serializer.SerializeWithLengthPrefix<ServerMessage>(networkStream,
                                        new ServerMessage.Builder(MessageType.LOG_IN_SUCCESSFUL).
                                        Task(currentTask).
                                        UserProfile(userProfile).
                                        StudentProgress(progress).
                                        Build(), PrefixStyle.Base128);
                                    didLoggedIn = true;
                                    serverPage.StudentLoggedIn(userProfile);
                                    HandleUserStream(client, userProfile, true, didLoggedIn);
                                    homePage.NewNotification(new Notification(NotificationType.LoggedIn, userProfile._studentName), userProfile);
                                }
                            }
                            if (!didLoggedIn)
                                Serializer.SerializeWithLengthPrefix<ServerMessage>(networkStream,
                                    new ServerMessage.Builder(MessageType.LOG_IN_FAILED).ErrorMessage(errorMsg).Build(), PrefixStyle.Base128);
                            await networkStream.FlushAsync();
                            break;
                        case MessageType.STUDENT_PROGRESS:
                            UpdateUserProgress(userProfile._studentId, obj._progress);
                            serverPage.UpdateStudentProgressDisplay(userProfile, obj._progress);
                            break;
                        case MessageType.CODE_SUBMISSION:
                            obj.submittedCode.user = userProfile;
                            progressSubmissionPage.StudentSubmitted(obj.submittedCode);
                            homePage.NewNotification(new Notification(NotificationType.Submitted, userProfile._studentName, ""), userProfile);
                            break;
                        case MessageType.NOTIFICATION:
                            homePage.NewNotification(obj.notification, userProfile);
                            break;
                        case MessageType.USER_MESSAGE:
                            serverPage.ReceivedStudentMessage(obj.userMessage, userProfile._studentId);
                            break;
                        default:
                            break;
                    }
                }
                catch (IOException ie)
                {
                    break;
                }
                catch (SocketException se)
                {
                    break;
                }
                catch (Exception ex)
                {
                    break;
                }
            }
            HandleUserStream(client, userProfile, false, didLoggedIn);
        }

        private void UpdateUserProgress(string studentId, StudentCodingProgress progress)
        {
            userProgress.AddOrUpdate(studentId, progress, (key, oldValue) => progress);
        }

        public StudentCodingProgress IdStudentProgress(string studentId)
        {
             return userProgress[studentId];
        }

        private void HandleUserStream(TcpClient client, UserProfile profile, bool isAdd, bool didLoggedIn)
        {
            try
            {
                if (isAdd)
                {
                    // Add new client; if key exists, dispose old client
                    connectedUsers.AddOrUpdate(profile._studentId, client, (k, oldClient) =>
                    {
                        try
                        {
                            oldClient?.GetStream()?.Close();
                            oldClient?.Close();
                        }
                        catch { }
                        return client;
                    });
                }
                else
                {
                    // Safely remove client
                    if (connectedUsers.TryRemove(profile._studentId, out TcpClient clientToClose))
                    {
                        try
                        {
                            clientToClose?.GetStream()?.Close();
                            clientToClose?.Close();
                        }
                        catch { }
                    }

                    currentStudents.TryRemove(profile._studentName, out _);
                    if (didLoggedIn)
                    {
                        // UI calls should be marshalled to the UI thread
                        try
                        {
                            serverPage.Invoke((MethodInvoker)(() => serverPage.StudentLoggedOut(profile)));
                        }
                        catch (KeyNotFoundException) { }
                        homePage.Invoke((MethodInvoker)(() => homePage.NewNotification(
                            new Notification(NotificationType.LoggedOut, profile._studentName), profile)));
                    }
                }
            }
            catch (Exception ex)
            {
                // optionally log the error
            }
        }

        //broadcasting service
        private void UpdateServerTask(TaskModel task, List<SubmittedCode> leaderboards, string msg)
        {
            serverPage.UpdateTask(task);
            Task.Run(async () =>
            {
                foreach (var item in connectedUsers)
                {
                    if(task != null)
                        await NotifyStudent(new ServerMessage.Builder(MessageType.TASK_UPDATE).Task(task).Build(), item.Key);
                    else if(leaderboards != null)
                        await NotifyStudent(new ServerMessage.Builder(MessageType.LEADERBOARDS_UPDATE).Leaderboards(leaderboards).Build(), item.Key);
                    else
                        await NotifyStudent(new ServerMessage.Builder(MessageType.USER_MESSAGE).UserMessage(new UserMessage(msg)).Build(), item.Key);
                }

                string notif = task != null ? "Server Task Updated Successfully" : msg != null ? "Broadcast Message Successfully Sent to Everyone" : string.Empty;
                if (notif != string.Empty)
                    NonBlockingNotification(notif);
            });
        }

        private void NonBlockingNotification(string message)
        {
            this.BeginInvoke((Action)(() => MessageBox.Show(message)));
        }

        private async void saveSession()
        {
            var newProgrammingSession = new ProgrammingSession(server, homePage.notifications,
                homePage.copyPasteDetectedCount,
                userProgress.ToDictionary(kvp => kvp.Key, kvp => kvp.Value),
                progressSubmissionPage.codeSubmissions);

            if (ServerServices.saveSession(server.ServerName, newProgrammingSession).Result)
                NonBlockingNotification("Session saved successfully.");
            else
                NonBlockingNotification("Failed to save session.");
        }
    }
}
