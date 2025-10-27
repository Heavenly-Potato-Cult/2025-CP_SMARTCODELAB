using ProtoBuf;
using SmartCodeLab.CustomComponents.GeneralComponents;
using SmartCodeLab.CustomComponents.Pages.ProgrammingTabs;
using SmartCodeLab.CustomComponents.Pages.ServerPages;
using SmartCodeLab.CustomComponents.ServerPageComponents.ExerciseManagerComponents;
using SmartCodeLab.Models;
using SmartCodeLab.Models.Enums;
using SmartCodeLab.Services;
using SmartCodeLab.Services.NamingConventions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace SmartCodeLab.CustomComponents.CustomDialogs
{

    public partial class ToDelete : Form
    {
        public ToDelete()
        {
            InitializeComponent();
            panel1.Controls.Add(new ReadabilityReasons("Improper or Inconsistent Indentation", ProgrammingConfiguration.readabilityIssues["Improper or Inconsistent Indentation"]));
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using(var existingExercises = new SelectExercise())
            {
                existingExercises.ShowDialog();
            }
        }
    }
}
