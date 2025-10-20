using FastColoredTextBoxNS;
using SmartCodeLab.CustomComponents.CustomDialogs.StudentTable;
using SmartCodeLab.CustomComponents.Pages;
using SmartCodeLab.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCodeLab.CustomComponents.ServerPageComponents
{
    public partial class TempSessionManagement : UserControl
    {
        private TaskModel selectedTask;
        private Dictionary<string, UserProfile> userProfiles;
        public TempSessionManagement()
        {
            InitializeComponent();
            userProfiles = new Dictionary<string, UserProfile>()
            {
                { "2", new UserProfile("Clifford", "2", "Slimparroot") },
            };
        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void TempSessionManagement_Load(object sender, EventArgs e)
        {

        }

        private void smartButton1_Click(object sender, EventArgs e)
        {
            if (serverName.Texts.IsWhiteSpace())
            {
                MessageBox.Show("Invalid Server Name");
                return;
            }
            else if (language.SelectedItem == null || language.SelectedItem.ToString() == "")
            {
                MessageBox.Show("No language Selected");
                return;
            }
            else if (serverPW.Texts.IsWhiteSpace())
            {
                MessageBox.Show("Server Password is Required");
                return;
            }
            else if (selectedTask == null)
            {
                selectedTask = new TaskModel();
            }
            selectedTask.ratingFactors = codeQualityChoices.GetRatingFactors();
            selectedTask.isTabLocked = tabNavigationLocked.Checked;
            Server server = new Server(serverName.Texts.Trim(), serverPW.Texts, selectedTask, language.SelectedItem.ToString(), userProfiles);

            SystemSingleton.Instance.page1.Controls.Clear();
            SystemSingleton.Instance.page1.AutoScroll = true;
            SystemSingleton.Instance.page1.Controls.Add(new MainServerPage(server));
        }

        private void smartButton2_Click(object sender, EventArgs e)
        {
            var studentTable = new StudTable(userProfiles);
            studentTable.ShowDialog();
            userProfiles = studentTable.expectedUsers;
            studentsCount.Text = userProfiles.Count.ToString();
        }

        private void smartButton4_Click(object sender, EventArgs e)
        {
            serverPW.Texts = new Random().Next(10000,100000).ToString();
        }
    }
}
