using System;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using SmartCodeLab.Properties;

namespace SmartCodeLab.CustomComponents.SteamThings
{
    public static class SteamFont
    {
        // "Singleton" for the font collection so we load it only once
        private static PrivateFontCollection _pfc;

        public static Font GetFont(float size, FontStyle style = FontStyle.Regular)
        {
            if (_pfc == null)
            {
                LoadCustomFonts();
            }

            // "Geist" is the family name. If it fails, fallback to Segoe UI
            try
            {
                return new Font(_pfc.Families[0], size, style);
            }
            catch
            {
                return new Font("Segoe UI", size, style);
            }
        }

        private static void LoadCustomFonts()
        {
            _pfc = new PrivateFontCollection();

            // Load Regular
            AddFontFromResource(Resources.Geist_Regular); // Name matches Resource tab

            // Load Bold (Optional, if you have a separate file)
            // AddFontFromResource(Resources.Geist_Bold);
        }

        private static void AddFontFromResource(byte[] fontData)
        {
            // WinForms requires unsafe memory handling to load embedded fonts
            int dataLength = fontData.Length;
            IntPtr ptrData = Marshal.AllocCoTaskMem(dataLength);

            // Copy binary data to safe memory
            Marshal.Copy(fontData, 0, ptrData, dataLength);

            // Add to our collection
            _pfc.AddMemoryFont(ptrData, dataLength);

            // Free memory (GDI+ makes a copy, so we can release ours)
            Marshal.FreeCoTaskMem(ptrData);
        }
    }
}
