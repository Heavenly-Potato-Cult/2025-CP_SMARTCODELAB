using ProtoBuf;
using SmartCodeLab.CustomComponents.ServerPageComponents.ClassManagerComponents;
using SmartCodeLab.Models;
using SmartCodeLab.Models.Enums;
using SmartCodeLab.Services;
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
using System.Timers;
using System.Windows.Forms;

namespace SmartCodeLab.CustomComponents.Pages
{
    public partial class ClassManagement : UserControl
    {
        private List<string> existingClassFiles;
        private Dictionary<string, ClassInformation> existingClasses;
        private Dictionary<string, ClassCard> classCards;
        private long searchVersion;
        private System.Threading.Timer searchTimer;
        public ClassManagement()
        {
            InitializeComponent();
            existingClasses = new Dictionary<string, ClassInformation>();
            existingClassFiles = new List<string>();
            classCards = new Dictionary<string, ClassCard>();

            foreach (var file in Directory.GetFiles(SystemConfigurations.CLASSES_DIRECTORY))
            {
                using (var fileStream = File.OpenRead(file))
                {
                    var classInfo = Serializer.DeserializeWithLengthPrefix<ClassInformation>(fileStream, PrefixStyle.Base128);
                    classCards.Add(classInfo.subjectCode, new ClassCard(classInfo, classesRetriever, updateClassInformation, removeClassInformation));
                    existingClassFiles.Add(classInfo.subjectCode);
                    existingClasses.Add(classInfo.subjectCode,classInfo);
                }
            }

            search.TextChanged += (s, e) =>
            {
                searchTimer?.Dispose();
                searchTimer = new System.Threading.Timer(async _ =>
                {
                    _ = displayIcons();
                }, null, 300, Timeout.Infinite);
            };

            this.Load += (s,e) => displayIcons();
        }

        private Task displayIcons()
        {
            long currentSearchVersion = ++searchVersion;
            string searchText = search.Text.ToLower();
            searchText = searchText.Equals("Search Class", StringComparison.OrdinalIgnoreCase) ? string.Empty : searchText;

            List<ClassCard> filteredClassCards = existingClasses.Values
                .Where(c => c.subjectCode.ToLower().Contains(searchText) ||
                            c.subjectDesc.ToLower().Contains(searchText) ||
                            c.course.ToLower().Contains(searchText) ||
                            c.section.ToLower().Contains(searchText) ||
                            c.schoolYear.ToLower().Contains(searchText))
                .Select(c => classCards[c.subjectCode])
                .ToList();

            this.Invoke(() =>
            {
                classesContainer.Controls.Clear();

                foreach (var classCard in filteredClassCards)
                {
                    if (currentSearchVersion != searchVersion)
                        return;

                    classesContainer.Controls.Add(classCard);
                }
            });

            return Task.CompletedTask;
        }

        private void updateClassInformation(string oldSubCode, ClassInformation newClassInfo)
        {
            var classCard = classCards[oldSubCode] ?? new ClassCard(newClassInfo, classesRetriever, updateClassInformation, removeClassInformation);
            removeClassInformation(oldSubCode);
            classCards.Add(newClassInfo.subjectCode, classCard);
            existingClasses.Add(newClassInfo.subjectCode, newClassInfo);
            displayIcons();
        }

        private void removeClassInformation(string subjectCode)
        {
            try
            {
                classCards.Remove(subjectCode);
                existingClasses.Remove(subjectCode);
                existingClassFiles.Remove(subjectCode);
            }
            catch (KeyNotFoundException) { }
        }

        private List<string> classesRetriever()
        {
            return existingClassFiles;
        }

        private ClassInformation GetSampleClassInfo()
        {
            return new ClassInformation.Builder()
                .WithSubjectCode("CS101")
                .WithSubjectDesc("Programming")
                .WithSchoolYear("2023-2024")
                .WithSemester(Semester.First)
                .WithCourse("BSCS")
                .WithSection("A")
                .WithYearLevel(1)
                .Build();
        }

        private void smartButton1_Click(object sender, EventArgs e)
        {
            var addClass = new AddClass(existingClassFiles);
            if(addClass.ShowDialog() == DialogResult.OK)
            {
                ClassInformation newClassInfo = addClass.currentClassInfo;
                classCards.Add(newClassInfo.subjectCode, new ClassCard(newClassInfo, classesRetriever, updateClassInformation, removeClassInformation));
                existingClassFiles.Add(newClassInfo.subjectCode);
                existingClasses.Add(newClassInfo.subjectCode, newClassInfo);
                displayIcons();
            }
        }
    }
}
