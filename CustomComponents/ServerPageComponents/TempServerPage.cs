using ProtoBuf;
using SmartCodeLab.CustomComponents.CustomDialogs.StudentTable;
using SmartCodeLab.CustomComponents.Pages.ServerPages;
using SmartCodeLab.Models;
using SmartCodeLab.Models.Enums;
using SmartCodeLab.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCodeLab.CustomComponents.ServerPageComponents
{
    public partial class TempServerPage : UserControl
    {
        public TempServerPage()
        {
            InitializeComponent();
        }

        private TaskModel currentTask { get; set; }
        //private TcpListener _server;
        //student ID as the key
        private Dictionary<string, UserIcons> userIcons = new Dictionary<string, UserIcons>();
        private StudentCodingProgress studentProgress;

        private string selectedStudentId = string.Empty;

        private Func<string, StudentCodingProgress> progressRetriever;
        public TempServerPage(TaskModel task, Dictionary<string, UserProfile> users, Func<string, StudentCodingProgress> progressRetriever)
        {
            InitializeComponent();
            currentTask = task;
            this.progressRetriever = progressRetriever;

            //will ensure that the handle is created before accessing the UI thread
            var obj = this.Handle;
            Task.Run(() =>
            {
                foreach (var item in users.Values)
                {
                    AddStudent(item);
                }
            });
            studentCodeRating.SetStats(task.ratingFactors);
        }

        public void AddStudent(UserProfile profile)
        {
            this.Invoke((Action)(() =>
            {
                //this will be used to view who are the students who are yet to log in or inactive(left the lobby), already logged in, and submitted
                profile._computerAddress = "";
                userIcons.Add(profile._studentId, new UserIcons(profile, NewUserSelected));
                iconsContainer.Controls.Add(userIcons[profile._studentId]);
            }));
        }

        public void StudentLoggedIn(UserProfile profile)
        {
            userIcons[profile._studentId].profile._computerAddress = profile._computerAddress;
        }

        public async void UpdateStudentProgressDisplay(UserProfile user, StudentCodingProgress progress)
        {
            if (user._studentId == selectedStudentId)
            {
                await Task.Run(() =>
                {
                    this.Invoke((Delegate)(() =>
                    {
                        studentProgress = progress;
                        int studentProgLength = studentProgress.CodeProgress.Count - 1;
                        bool atMax = codeTrack.Maximum == codeTrack.Value;
                        codeTrack.Maximum = studentProgLength;
                        if (atMax)
                        {
                            studentCode.Text = studentProgress.sourceCode;
                            codeTrack.Value = studentProgLength;
                        }

                        copypastedCodes.Controls.Clear();
                        if (studentProgress.pastedCode != null)
                        {
                            foreach (var item in studentProgress.pastedCode)
                            {
                                copypastedCodes.Controls.Add(new PastedCodeIcon(item));
                            }
                        }
                        studentCodeRating.SetStudentStats(progress.codeStats);
                    }));
                });
            }
        }

        public void UpdateTask(TaskModel task)
        {
            currentTask = task;
        }

        private void NewUserSelected(UserProfile profile)
        {
            selectedStudentId = profile._studentId;
            try
            {
                UpdateStudentProgressDisplay(profile, progressRetriever?.Invoke(profile._studentId));
            }
            catch (KeyNotFoundException) { }

            studentName.Text = profile._studentName;
            ipaddress.Text = profile._computerAddress;
        }
        private void codeTrack_Scroll(object sender, EventArgs e)
        {
            if (studentProgress == null)
                return;

            studentCode.Text = studentProgress.CodeProgress[codeTrack.Value];
        }
    }
}
