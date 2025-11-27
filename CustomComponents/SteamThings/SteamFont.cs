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

        // --- THE NEW GETFONT ---
        // Now accepts an optional "familyName" parameter. 
        // Defaults to "Geist" if you don't specify.
        public static Font GetFont(float size, FontStyle style = FontStyle.Regular, string familyName = "Geist")
        {
            if (_pfc == null)
            {
                LoadCustomFonts();
            }

            try
            {
                // Find the specific font family in our collection
                // This handles looking for "Geist Mono" vs just "Geist"
                var family = _pfc.Families.FirstOrDefault(f => f.Name.Equals(familyName, StringComparison.OrdinalIgnoreCase));

                // If found, use it. If not found (null), default to the first one (usually Geist Regular).
                if (family != null)
                {
                    return new Font(family, size, style);
                }

                // Fallback if "Geist Mono" wasn't found
                return new Font(_pfc.Families[0], size, style);
            }
            catch
            {
                // Emergency Fallback
                return new Font("Consolas", size, style);
            }
        }

        private static void LoadCustomFonts()
        {
            _pfc = new PrivateFontCollection();

            // 1. Load Standard Sans (UI)
            AddFontFromResource(Resources.Geist_Regular);
            AddFontFromResource(Resources.Geist_Bold); // Optional if you have bold

            // 2. Load Monospace (Logs)
            // Make sure you added "GeistMono_Regular" to Resources.resx first!
            AddFontFromResource(Resources.GeistMono_Regular);
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
