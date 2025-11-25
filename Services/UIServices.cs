using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCodeLab.Services
{
    public class UIServices
    {
        public static bool SelectYesNo(string msg)
        {
            DialogResult result = MessageBox.Show(msg, "Confirmation",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            return result == DialogResult.Yes;
        }
        public static void OKDialogSucess(string msg, string caption)
        {
           MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
