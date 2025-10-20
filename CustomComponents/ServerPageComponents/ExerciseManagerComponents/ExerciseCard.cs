using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartCodeLab.CustomComponents.GeneralComponents;

namespace SmartCodeLab.CustomComponents.ServerPageComponents.ExerciseManagerComponents
{
    public partial class ExerciseCard : RoundedUserControl
    {
        public ExerciseCard()
        {
            InitializeComponent();
        }

        private string
            _title,
            _programmingLanguage,
            _classCourse,
            _classYearAndSection;


        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Title 
        {
            get { return _title; }
            set 
            { 
                _title = value; 
                lbl_ExerciseTitle.Text = value; 
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string ProgrammingLanguage
        {
            get { return _programmingLanguage; }
            set
            {
                _programmingLanguage = value;
                lbl_ExerciseLanguange.Text = value;
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string ClassCourse
        {
            get { return _classCourse; }
            set
            {
                _classCourse = value;
                lbl_ExerciseCourse.Text = value; 
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string ClassYearAndSection
        {
            get { return _classYearAndSection; }
            set
            {
                _classYearAndSection = value;
                lbl_ExerciseYearAndSection.Text = value;
            }
        }
    }
}
