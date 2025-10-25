﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCodeLab.CustomComponents.ServerPageComponents.ExerciseManagerComponents
{
    public partial class TestCase : UserControl
    {
        public TestCase()
        {
            InitializeComponent();
        }

        public TestCase(KeyValuePair<string, string> testCase)
        {
            InitializeComponent();
            codeEditor1.Text = testCase.Key;
            codeEditor2.Text = testCase.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void TestCase_Click(object sender, EventArgs e)
        {
            if (this.Size.Height == 30)
                this.Size = new Size(this.Size.Width, 230);
            else
                this.Size = new Size(this.Size.Width, 30);
        }

        public KeyValuePair<string, string> GetTestCase()
        {
            return new KeyValuePair<string, string>(codeEditor1.Text, codeEditor2.Text);
        }
    }
}
