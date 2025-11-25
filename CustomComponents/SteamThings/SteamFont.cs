using System;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using SmartCodeLab.Properties;

namespace SmartCodeLab.CustomComponents.SteamThings
{
    public static class SteamFont
    {
        
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

           
            AddFontFromResource(Resources.Geist_Regular); 

           
        }

        private static void AddFontFromResource(byte[] fontData)
        {
           
            int dataLength = fontData.Length;
            IntPtr ptrData = Marshal.AllocCoTaskMem(dataLength);

           
            Marshal.Copy(fontData, 0, ptrData, dataLength);

            _pfc.AddMemoryFont(ptrData, dataLength);

           
            Marshal.FreeCoTaskMem(ptrData);
        }
    }
}
