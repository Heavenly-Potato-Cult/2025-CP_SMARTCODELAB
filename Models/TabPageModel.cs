using SmartCodeLab.CustomComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCodeLab.Models
{
    public class TabPageModel : TabPage
    {
        public CustomTabHeader _customTabHeader { get; }
        public TabPageModel(string headerText,TabControl tabControl, UserControl _content)
        {
            Controls.Add(_content);
            _customTabHeader = new CustomTabHeader(headerText,tabControl, this);
        }
    }
}
