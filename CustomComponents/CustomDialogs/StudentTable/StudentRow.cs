using SmartCodeLab.Models;
using SmartCodeLab.Services;
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
    public partial class StudentRow : UserControl
    {
        public StudentRow(string studentId, string name, Action<string> removeUser, Action<UserProfile> updateDisplay, Func<ServerMessage, string, Task> kickStudent = null)
        {
            InitializeComponent();
            this.studId.Text = studentId;
            this.studName.Text = name;
            string studentName = name;

            this.MouseEnter += (s, e) =>
            {
                BackColor = Color.CadetBlue;
            };
            this.MouseLeave += (s, e) =>
            {
                BackColor = SystemColors.ControlLightLight;
            };

            this.MouseClick += (s, e) => 
            {
                if(e.Button == MouseButtons.Right)
                {
                    var option = new FloatingOptions();
                    option.deleteRecord = new Action(() =>
                    {
                        removeUser?.Invoke(studentId);
                        this.Dispose();
                    });

                    option.editRecord = new Action(() => 
                    {
                        MessageBox.Show("");
                        var studForm = new StudentForm(studentId, studentName);
                        if (studForm.ShowDialog() == DialogResult.OK)
                        {
                            KeyValuePair<string, string> userDetails = studForm.NewUser();
                            updateDisplay?.Invoke(new UserProfile(userDetails.Value, userDetails.Key, "N/A"));
                            studentName = userDetails.Value;
                        }
                    });

                    if(kickStudent != null)
                    {
                        option.kickStudent = new Action(() =>
                        {
                            kickStudent?.Invoke(new ServerMessage.Builder(Models.Enums.MessageType.KICKED).Build(), studentId);
                        });
                    }
                    option.Show();
                }
            };
        }

        public void setNameText(string name)
        {
            studName.Text = name;
        }
    }
}
