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
