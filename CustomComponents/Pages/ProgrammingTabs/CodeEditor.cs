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
        //okay now?
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
            //this.TextChangedDelayed += (s, e) =>
            //{
            //    this.Range.ClearFoldingMarkers();

            //    var currentIndent = 0;
            //    var lastNonEmptyLine = 0;

            //    for (int i = 0; i < this.LinesCount; i++)
            //    {
            //        var line = this[i];
            //        var spacesCount = line.StartSpacesCount;
            //        if (spacesCount == line.Count) //empty line
            //            continue;

            //        if (currentIndent < spacesCount)
            //            //append start folding marker
            //            this[lastNonEmptyLine].FoldingStartMarker = "m" + currentIndent;
            //        else
            //        if (currentIndent > spacesCount)
            //            //append end folding marker
            //            this[lastNonEmptyLine].FoldingEndMarker = "m" + spacesCount;

            //        currentIndent = spacesCount;
            //        lastNonEmptyLine = i;
            //    }
            //};
        }
    }
}
