using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Diagnostics;

namespace SmartCodeLab.CustomComponents.GeneralComponents
{
    public class CustomNumericUpDown : NumericUpDown
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Func<decimal> remainingUnallocated { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Action<decimal> updateUnallocatedValue { get; set; }


        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public decimal recentValue;
        public CustomNumericUpDown()
        {
            ValueChanged += (sender, e) =>
            {
                if (remainingUnallocated != null) 
                {
                    updateUnallocatedValue?.Invoke(recentValue - this.Value);
                    if(remainingUnallocated.Invoke() < 0)
                    {
                        decimal val = this.Value + remainingUnallocated.Invoke();
                        recentValue = val;
                        updateUnallocatedValue?.Invoke(Math.Abs(remainingUnallocated.Invoke()));
                        this.Value = val;
                    }
                    recentValue = this.Value;
                }
            };
        }

        //this will be used for accuracy only. if other choices was disabled, its value will be transfered to the accuracy
        public void InheritValues(decimal value)
        {
            this.Value += value;
        }
    }
}
