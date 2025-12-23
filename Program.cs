using SmartCodeLab.CustomComponents.CustomDialogs;
using SmartCodeLab.Models;
using SmartCodeLab.Services;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;

namespace SmartCodeLab
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Configure exception handlers FIRST
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += (sender, e) => {
                MessageBox.Show($"Global UI exception: {e.Exception.Message}");
                // Log the exception
            };

            AppDomain.CurrentDomain.UnhandledException += (sender, e) => {
                MessageBox.Show($"Global non-UI exception: {(e.ExceptionObject as Exception)?.Message}");
                // Log the exception
            };

            List<string> requiredFolders = new List<string>
            {
                SystemConfigurations.TASK_FOLDER,
                SystemConfigurations.SESSIONS_FOLDER,
                SystemConfigurations.javaFolder,
                SystemConfigurations.pythonFolder,
                SystemConfigurations.cppFolder
            };

            requiredFolders.ForEach(folder =>
            {
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }
            });

            ConfigureFirewallRules();
            Application.Run(new InstructorForm()); //start up for instructor

            //for student side
            //TcpClient client = new TcpClient();
            //var searchServer = new LoadingDialog(client);
            //searchServer.ShowDialog();
            //if (client.Connected)
            //{
            //    var userLogIn = new UserLogInDIalog(client);
            //    if (userLogIn.ShowDialog() == DialogResult.OK)
            //    {
            //        var studentProgramming = new TempIDE(userLogIn._userName, userLogIn.serverTask, userLogIn.progress, userLogIn._stream);
            //        SystemSingleton.Instance._loggedIn = true;
            //        studentProgramming.ShowDialog();
            //    }
            //    else
            //    {
            //        SystemSingleton.Instance._loggedIn = false;
            //        userLogIn.Dispose();
            //        return;
            //    }
            //    searchServer.CloseMe();
            //    userLogIn.Dispose();
            //}
            //else
            //    return;
        }

        private static void ConfigureFirewallRules()
        {
            if (!FirewallRuleExists("Temp_Port") || !FirewallRuleExists("Temporary_Port_Allow"))
            {
                OpenNetshAsAdmin($"/c \"{SystemConfigurations.OPEN_FIREWALL_PORTS_BAT}\"");
            }
            // Clean up on application exit
            Application.ApplicationExit += (s, e) =>
            {
                //if (FirewallRuleExists("Temporary_Port_Allow") || FirewallRuleExists("Temporary_Port_Allow"))
                //{
                //    OpenNetshAsAdmin($"/c {SystemConfigurations.REMOVE_FIREWALL_PORTS_BAT}");
                //}
            };
        }


        private static bool FirewallRuleExists(string ruleName)
        {
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "netsh",
                    Arguments = $"advfirewall firewall show rule name=\"{ruleName}\"",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                };

                using (Process process = Process.Start(startInfo))
                {
                    string output = process.StandardOutput.ReadToEnd();
                    process.WaitForExit();
                    return output.Contains("Rule Name") && !output.Contains("No rules match");
                }
            }
            catch
            {
                return false;
            }
        }

        public static void OpenNetshAsAdmin(string command)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = command,
                Verb = "runas", // This requests admin privileges
                UseShellExecute = true,
                WindowStyle = ProcessWindowStyle.Normal
            };

            try
            {
                Process.Start(startInfo);
            }
            catch (System.ComponentModel.Win32Exception ex)
            {
                // User cancelled the UAC prompt
                Console.WriteLine("Admin privileges required: " + ex.Message);
            }
        }
    }
}