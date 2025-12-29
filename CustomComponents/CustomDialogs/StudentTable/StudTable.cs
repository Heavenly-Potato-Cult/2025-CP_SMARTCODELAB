using Microsoft.VisualBasic.FileIO;
using Microsoft.Win32;
using ProtoBuf.WellKnownTypes;
using SmartCodeLab.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenFileDialog = System.Windows.Forms.OpenFileDialog;

namespace SmartCodeLab.CustomComponents.CustomDialogs.StudentTable
{
    public partial class StudTable : Form
    {
        public List<UserProfile> newlyAdded { get; private set; }
        public Dictionary<string, UserProfile> expectedUsers;
        private Action<List<UserProfile>> updateIcons;
        private Action<UserProfile, bool> updateDisplay;
        private Dictionary<string, StudentRow> userIcons;
        private Func<ServerMessage, string, Task> kickStudent;
        //right after adding the student, should add its icon to the temp server page

        public StudTable()
        {
            InitializeComponent();
            newlyAdded = new List<UserProfile>();
            expectedUsers = new Dictionary<string, UserProfile>();
            userIcons = new Dictionary<string, StudentRow>();
        }

        public StudTable(Dictionary<string, UserProfile> users, Action<List<UserProfile>> updateIcons = null, Action<UserProfile, bool> updateDisplay = null, Func<ServerMessage, string, Task> kickStudent = null)
        {
            InitializeComponent();
            this.updateDisplay = updateDisplay;
            this.updateIcons = updateIcons;
            this.kickStudent = kickStudent;
            newlyAdded = new List<UserProfile>();
            expectedUsers = users;
            count.Text = users.Count.ToString();
            userIcons = new Dictionary<string, StudentRow>();
            foreach (var user in users.Values)
            {
                var userRow = new StudentRow(user._studentId, user._studentName, removeUser, updateUserDisplay, kickStudent);
                userIcons.Add(user._studentId, userRow);
                studtab.Controls.Add(userRow);
            }
        }

        private void updateUserDisplay(UserProfile user)
        {
            expectedUsers[user._studentId] = user;
            updateDisplay?.Invoke(user, true);
        }

        private void removeUser(string userId)
        {
            MessageBox.Show(this, "Removing user with user id " + userId);
            updateDisplay?.Invoke(expectedUsers[userId], false);
            expectedUsers.Remove(userId);
            count.Text = expectedUsers.Count.ToString();
        }

        public bool ContainsUser(string studentId)
        {
            return expectedUsers.ContainsKey(studentId);
        }

        private void smartButton2_Click(object sender, EventArgs e)
        {
            StudentForm frm = new StudentForm();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.Invoke((Action)(() =>
                {
                    KeyValuePair<string, string> newUser = frm.NewUser();
                    if (ContainsUser(newUser.Key))
                    {
                        MessageBox.Show("User Id Already Exists");
                        return;
                    }
                    var newAddedUser = new UserProfile(newUser.Value, newUser.Key, "N/A");
                    var newUserIcon = new StudentRow(newUser.Key, newUser.Value, removeUser, updateUserDisplay, kickStudent);
                    expectedUsers.Add(newUser.Key, newAddedUser);
                    userIcons.Add(newAddedUser._studentId, newUserIcon);
                    studtab.Controls.Add(newUserIcon);
                    updateIcons?.Invoke(new List<UserProfile>() { newAddedUser });
                    newlyAdded.Add(newAddedUser);
                    count.Text = int.Parse(count.Text) + 1 + "";
                }));
            }
            frm.Close();
            frm = null;
            count.Text = expectedUsers.Count.ToString();
        }

        public async Task<Dictionary<string, UserProfile>?> getStudentsFromCSV(string filepath)
        {
            if (!File.Exists(filepath))
                return null;

            var users = new Dictionary<string, UserProfile>();
            bool isFirst = true;
            int nameIndex = -1; 
            int studentIdIndex = -1;
            using (TextFieldParser parse = new TextFieldParser(filepath))
            {
                parse.TextFieldType = FieldType.Delimited;
                parse.SetDelimiters(",");

                while(!parse.EndOfData)
                {
                    string[] fields = parse.ReadFields();
                    if (isFirst)
                    {
                        (nameIndex, studentIdIndex) = GetColumnIndices(string.Join("/|\\", fields));
                        if (nameIndex == -1 || studentIdIndex == -1)
                        {
                            NonBlockingNotification("Appropriate column names(\"Name\" and \"Student Id\") are not found in the file.");
                            break;
                        }
                        isFirst = false;
                    }
                    else
                    {
                        string studentName = string.Empty;
                        string studentId = string.Empty;
                        int pos = 0;
                        foreach (var field in fields)
                        {
                            if(pos == nameIndex)
                                studentName = field;
                            else if (pos == studentIdIndex)
                                studentId = field;

                            pos++;
                        }
                        if (!studentId.IsWhiteSpace())
                            users.Add(studentId, new UserProfile(studentId, studentName, true));
                    }
                }
                return await Task.Run(() =>
                {
                    return users;
                });
            }
        }

        private async Task<Dictionary<string, UserProfile>?> GetStudentProfiles(string filepath) //let's assume that the file is csv
        {
            if (!File.Exists(filepath))
                return null;
            string[] stringLines = null;
            try
            {
                stringLines = await File.ReadAllLinesAsync(filepath);
            }catch(IOException io) {
                NonBlockingNotification(io.Message);
                return new Dictionary<string, UserProfile>();
            }

            var (nameIndex, studentIdIndex) = GetColumnIndices(stringLines[0]);
            if (nameIndex == -1 || studentIdIndex == -1)
            {
                NonBlockingNotification("Appropriate column names(\"Name\" and \"Student Id\") are not found in the file.");
                return null;
            }

            return await Task.Run(() =>
            {
                var users = new Dictionary<string, UserProfile>();

                for (int i = 1; i < stringLines.Length; i++)
                {
                    try
                    {
                        string[] line = stringLines[i].Split(',');
                        string studentId = line[studentIdIndex];
                        string studentName = line[nameIndex];

                        if (!studentId.IsWhiteSpace())
                            users.Add(studentId, new UserProfile(studentId, studentName, true));
                    }
                    catch (IndexOutOfRangeException) { }
                }

                return users;
            });
        }
        private void NonBlockingNotification(string message)
        {
            this.BeginInvoke((Action)(() => MessageBox.Show(message)));
        }
        private (int nameIndex, int studentIdIndex) GetColumnIndices(string firstRow)
        {
            int nameColumnIndex = -1;
            int studentColumnIndex = -1;

            string[] lineTokens = firstRow.Split("/|\\");
            for (int i = 0; i < lineTokens.Length; i++)
            {
                if (lineTokens[i].Trim().Equals("Name", StringComparison.OrdinalIgnoreCase))
                    nameColumnIndex = i;
                else if (lineTokens[i].Trim().Equals("Student Id", StringComparison.OrdinalIgnoreCase))
                    studentColumnIndex = i;

                if(nameColumnIndex != -1 && studentColumnIndex != -1)
                    break;
            }

            return (nameColumnIndex, studentColumnIndex);
        }

        private async void smartButton1_Click(object sender, EventArgs e)
        {
            NonBlockingNotification("Please select the CSV file containing student records with 'Name' and 'Student Id' columns.");
            using (var fileDialog = new OpenFileDialog()) 
            {
                fileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                fileDialog.Title = "Select Student Records File";
                fileDialog.Multiselect = false;

                if(fileDialog.ShowDialog() == DialogResult.OK)
                {
                    var studentRecords = await getStudentsFromCSV(fileDialog.FileName);
                    await Task.Run(() =>
                    {
                        if (studentRecords == null)
                            NonBlockingNotification("File is missing the required columns");
                        else if (studentRecords.Count == 0)
                            NonBlockingNotification("No student record found");
                        else
                        {
                            var addedUsers = new List<UserProfile>();
                            foreach (var item in studentRecords)
                            {
                                if (!expectedUsers.ContainsKey(item.Key) && !item.Key.IsWhiteSpace())
                                {
                                    var newlyAddedUser = new UserProfile(item.Value._studentName, item.Value._studentId, "N/A");
                                    var newUserIcon = new StudentRow(item.Key, item.Value._studentName, removeUser, updateUserDisplay, kickStudent);
                                    expectedUsers.Add(item.Key, item.Value);
                                    addedUsers.Add(newlyAddedUser);
                                    newlyAdded.Add(newlyAddedUser);
                                    userIcons.Add(newlyAddedUser._studentId, newUserIcon);
                                    this.Invoke(new Action(() =>
                                    {
                                        studtab.Controls.Add(newUserIcon);
                                    }));
                                }
                            }
                            updateIcons?.Invoke(addedUsers);
                        }
                    });
                }
                count.Text = expectedUsers.Count.ToString();
            }
        }
    }
}
