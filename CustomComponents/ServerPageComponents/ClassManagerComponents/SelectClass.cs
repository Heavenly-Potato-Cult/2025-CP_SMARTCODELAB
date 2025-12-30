using ProtoBuf;
using SmartCodeLab.Models;
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
using System.Windows.Forms;

namespace SmartCodeLab.CustomComponents.ServerPageComponents.ClassManagerComponents
{
    public partial class SelectClass : Form
    {

        private System.Threading.Timer displayTimer;
        private Action<ClassInformation> onExerciseSelected;
        private Dictionary<string, ClassSelection> iconsDictionary;
        private List<ClassInformation> classInformationList;
        private long searchVersion;
        public Dictionary<string, ClassInformation> selectedClasses { get; private set; }
        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams cp = base.CreateParams;
        //        cp.ExStyle |= 0x02000000; // WS_EX_COMPOSITED
        //        return cp;
        //    }
        //}

        public SelectClass()
        {
            InitializeComponent();
            selectedClasses = new Dictionary<string, ClassInformation>();
            iconsDictionary = new Dictionary<string, ClassSelection>();
            classInformationList = new List<ClassInformation>();

            var exerciseFiles = Directory.GetFiles(SystemConfigurations.CLASSES_DIRECTORY, "*.dat");
            foreach (var item in exerciseFiles)
            {
                using(var readFile = File.OpenRead(item))
                {
                    var classInfo = Serializer.DeserializeWithLengthPrefix<ClassInformation>(readFile, PrefixStyle.Base128);
                    iconsDictionary[classInfo.subjectCode] = new ClassSelection(classInfo);
                    classInformationList.Add(classInfo);
                }
            }
            Load += (s,e) => displayIcons();
        }

        private Task displayIcons()
        {
            long curentCount = ++searchVersion;
            string searchText = searchBox.Texts.ToLower();
            searchText = searchText.Equals("Search Class", StringComparison.OrdinalIgnoreCase) ? string.Empty : searchText;

            List<ClassSelection> filteredClassCards = classInformationList
                .Where(c => c.subjectCode.ToLower().Contains(searchText) ||
                            c.subjectDesc.ToLower().Contains(searchText) ||
                            c.course.ToLower().Contains(searchText) ||
                            c.section.ToLower().Contains(searchText) ||
                            c.schoolYear.ToLower().Contains(searchText))
                .Select(c => iconsDictionary[c.subjectCode])
                .ToList();

            this.Invoke(new Action(() =>
            {
                holder.Controls.Clear();
                foreach (var item in filteredClassCards)
                {
                    holder.Controls.Add(item);
                }
            }));

            return Task.CompletedTask;
        }


        private void searchBox__TextChanged(object sender, EventArgs e)
        {
            displayTimer?.Change(Timeout.Infinite, Timeout.Infinite);
            displayTimer = new System.Threading.Timer(_ =>
            {
                _ = displayIcons();
            }, null, 300, Timeout.Infinite);
        }

        private Action<ClassInformation> classSelected => (task) =>
        {
            onExerciseSelected?.Invoke(task);
            this.DialogResult = DialogResult.OK;
            this.Close();
        };
    }
}
