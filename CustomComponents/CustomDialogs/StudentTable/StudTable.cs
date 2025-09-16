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

namespace SmartCodeLab.CustomComponents.CustomDialogs.StudentTable
{
    public partial class StudTable : Form
    {
        public StudTable()
        {
            InitializeComponent();
        }

        Dictionary<string, UserProfile> expectedUsers;
        public StudTable(Dictionary<string, UserProfile> users)
        {
            InitializeComponent();
            expectedUsers = users;
            foreach (var user in users.Values)
            {
                studtab.Controls.Add(new StudentRow(user._studentId, user._studentName));
            }
        }

        public bool ContainsUser(string studentId)
        {
            return expectedUsers.ContainsKey(studentId);
        }

        public UserProfile GetUserProfile(string userId)
        {
            return expectedUsers[userId];
        }

        private void smartButton1_Click(object sender, EventArgs e)
        {
            StudentForm frm = new StudentForm();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                this.Invoke((Action)(() =>
                {
                    KeyValuePair<string, string> newUser = frm.NewUser();
                    if (ContainsUser(newUser.Key)) 
                    {
                        MessageBox.Show("User Id Already Exists");
                        return;
                    }
                    expectedUsers.Add(newUser.Key, new UserProfile(newUser.Value, newUser.Key,"N/A"));
                    studtab.Controls.Add(new StudentRow(newUser.Key,newUser.Value));
                }));
            }
            frm = null;
        }
    }
}
