using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCodeLab.CustomComponents.CustomDialogs
{
    public partial class ViewCodeViolations : Form
    {
        public ViewCodeViolations()
        {
            InitializeComponent();
        }

        public ViewCodeViolations(List<HashSet<string>> violations)
        {
            InitializeComponent();

            this.Load += (s, e) =>
            {
                Task.Run(() => fillTextBox(readability, violations[0]));
                Task.Run(() => fillTextBox(maintainability, violations[1]));
                Task.Run(() => fillTextBox(robustness, violations[2]));
            };
        }

        private void fillTextBox(MaterialMultiLineTextBox textBox, HashSet<string> violations)
        {
            foreach (var item in violations)
            {
                this.Invoke(new Action(() => textBox.AppendText(item + Environment.NewLine)));
            }
        }
    }
}
