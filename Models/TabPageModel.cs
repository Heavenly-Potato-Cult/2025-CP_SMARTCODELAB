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
        public TabPageModel(string headerText,TabControl tabControl, UserControl _content, ISet<string> pages)
        {
            Controls.Add(_content);
            _customTabHeader = new CustomTabHeader(Path.GetFileName(headerText), tabControl, this);
            _customTabHeader.CloseButton.Click += (sender, e) =>
            {
                tabControl.TabPages.Remove(this);
                _customTabHeader.Dispose();
                pages.Remove(headerText);
            };

            TaskModel task = new TaskModel();
            task._taskName = headerText;
        }
    }
}
