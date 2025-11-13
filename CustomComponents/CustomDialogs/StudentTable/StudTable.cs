using Microsoft.Win32;
using SmartCodeLab.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public StudTable()
        {
            InitializeComponent();
        }

        public Dictionary<string, UserProfile> expectedUsers;
        public StudTable(Dictionary<string, UserProfile> users)
        {
            InitializeComponent();
            expectedUsers = users;
            count.Text = users.Count.ToString();
            foreach (var user in users.Values)
            {
                studtab.Controls.Add(new StudentRow(user._studentId, user._studentName));
            }
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
                    expectedUsers.Add(newUser.Key, new UserProfile(newUser.Value, newUser.Key, "N/A"));
                    studtab.Controls.Add(new StudentRow(newUser.Key, newUser.Value));
                    count.Text = int.Parse(count.Text) + 1 + "";
                }));
            }
            frm.Close();
            frm = null;
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
                MessageBox.Show(io.Message);
                return new Dictionary<string, UserProfile>();
            }

            var (nameIndex, studentIdIndex) = GetColumnIndices(stringLines[0]);
            if (nameIndex == -1 || studentIdIndex == -1)
            {
                MessageBox.Show("Appropriate column names(\"Name\" and \"Student Id\") are not found in the file.");
                return null;
            }

            return await Task.Run(() =>
            {
                var users = new Dictionary<string, UserProfile>();

                for (int i = 1; i < stringLines.Length; i++)
                {
                    string[] line = stringLines[i].Split(',');
                    string studentId = line[studentIdIndex];
                    string studentName = line[nameIndex];

                    if (!studentId.IsWhiteSpace())
                        users.Add(studentId, new UserProfile(studentId, studentName, true));
                }

                return users;
            });
        }

        private (int nameIndex, int studentIdIndex) GetColumnIndices(string firstRow)
        {
            int nameColumnIndex = -1;
            int studentColumnIndex = -1;

            string[] lineTokens = firstRow.Split(",");
            for (int i = 0; i < lineTokens.Length; i++)
            {
                if (lineTokens[i].Trim().Equals("Name", StringComparison.OrdinalIgnoreCase))
                    nameColumnIndex = i;
                else if (lineTokens[i].Trim().Equals("Student Id", StringComparison.OrdinalIgnoreCase))
                    studentColumnIndex = i;
            }

            return (nameColumnIndex, studentColumnIndex);
        }

        private async void smartButton1_Click(object sender, EventArgs e)
        {
            using (var fileDialog = new OpenFileDialog()) 
            {
                fileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                fileDialog.Title = "Select Student Records File";
                fileDialog.Multiselect = false;

                if(fileDialog.ShowDialog() == DialogResult.OK)
                {
                    var studentRecords = await GetStudentProfiles(fileDialog.FileName);

                    await Task.Run(() => 
                    {

                        if (studentRecords == null) 
                        {
                            MessageBox.Show("File is missing the required columns");
                        }
                        else if (studentRecords.Count == 0) 
                        {
                            MessageBox.Show("No student record found");
                        }
                        else
                        {
                            foreach (var item in studentRecords)
                            {
                                if (!expectedUsers.ContainsKey(item.Key))
                                {
                                    expectedUsers.Add(item.Key, item.Value);
                                    this.Invoke(new Action(() =>
                                    {
                                        studtab.Controls.Add(new StudentRow(item.Key, item.Value._studentName));
                                    }));
                                }
                            }
                        }
                    } );
                }
            }
        }
    }
}
