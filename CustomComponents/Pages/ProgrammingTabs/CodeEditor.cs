using FastColoredTextBoxNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCodeLab.CustomComponents.Pages.ProgrammingTabs
{
    public class CodeEditor : FastColoredTextBoxNS.FastColoredTextBox
    {
        public CodeEditor()
        {
            RichTextBox richTextBox = new RichTextBox();
            richTextBox.Dock = DockStyle.Fill;

            // Add text with different parts
            richTextBox.Text = "This part is editable\nThis part is READ ONLY\nThis part is also editable";

            // Make specific line read-only
            int readOnlyStart = richTextBox.GetFirstCharIndexFromLine(1); // Second line
            int readOnlyLength = richTextBox.Lines[1].Length;

            richTextBox.Select(readOnlyStart, readOnlyLength);
            richTextBox.SelectionProtected = true;

            // Handle protection
            richTextBox.SelectionChanged += (sender, e) =>
            {
                if (richTextBox.SelectionProtected)
                {
                    // Move selection to editable area
                    richTextBox.Select(0, 0);
                }
            };
        }
    }
}
