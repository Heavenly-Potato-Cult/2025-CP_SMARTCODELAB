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
    public partial class ToDelete : Form
    {
        public ToDelete()
        {
            InitializeComponent();
            codeRatingui1.SetStats(new Dictionary<int, decimal[]>()
            {
                {1,new decimal[]{40 } },
                {2,new decimal[]{20 } },
                {3,new decimal[]{20 } },
                {4,new decimal[]{20 } }
            });
        }
    }
}
