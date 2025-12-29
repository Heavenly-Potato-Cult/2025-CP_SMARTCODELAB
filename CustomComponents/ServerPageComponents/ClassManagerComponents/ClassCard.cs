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
using SmartCodeLab.CustomComponents.GeneralComponents;
using SmartCodeLab.Models;
using SmartCodeLab.Services;

namespace SmartCodeLab.CustomComponents.ServerPageComponents.ClassManagerComponents
{
    public partial class ClassCard : UserControl
    {
        string filepath;
        public ClassCard()
        {
            InitializeComponent();
        }

        public ClassCard(ClassInformation classInfo, Func<List<string>> classesRetriver, Action<string, ClassInformation> updateClass, Action<string> remover)
        {
            InitializeComponent();
            setDisplay(classInfo);
            filepath = classInfo.filepath;
            string originalSubjectCode = classInfo.subjectCode;
            btn_editcard.Click += (s, e) =>
            {
                var viewClass = new AddClass(classInfo, classesRetriver.Invoke());
                if (viewClass.ShowDialog() == DialogResult.OK)
                {
                    setDisplay(viewClass.currentClassInfo);
                    classInfo = viewClass.currentClassInfo;
                    updateClass.Invoke(originalSubjectCode, viewClass.currentClassInfo);
                    originalSubjectCode = viewClass.currentClassInfo.subjectCode;
                    filepath = viewClass.currentClassInfo.filepath;
                }
                viewClass.Dispose();
            };

            smartButton9.Click += (s, e) =>
            {
                var confirm = MessageBox.Show("Are you sure you want to delete this class?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        if (File.Exists(filepath))
                        {
                            File.Delete(filepath);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting class file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    remover.Invoke(classInfo.subjectCode);
                    this.Dispose();
                }
            };
        }

        private void setDisplay(ClassInformation classInfo)
        {
            subjectCode.Text = classInfo.subjectCode;
            subject.Text = classInfo.subjectDesc;
            courseYearSec.Text = $"{classInfo.course} - {classInfo.yearLevel}{classInfo.section}";
            SYSem.Text = $"{classInfo.schoolYear} - {classInfo.semester.ToString()}";
        }

        private string GetSteamDate(DateTime date)
        {

            var diff = DateTime.Now - date;


            if (date.Date == DateTime.Today)
            {
                return "Today";
            }
            else if (date.Date == DateTime.Today.AddDays(-1))
            {
                return "Yesterday";
            }
            else
            {

                return date.ToString("MMM dd, yyyy");
            }
        }
    }
}
