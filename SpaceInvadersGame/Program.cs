using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceInvadersGame
{
    internal static class Program
    {
        static private List<PrivateFontCollection> _fontCollections; // List for correctly disposing collection

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true); // Set this to true (default false) to get the custom font to work

            // Disposing collection when program closes
            Application.ApplicationExit += delegate
            {
                if (_fontCollections != null)
                {
                    foreach (var fc in _fontCollections) if (fc != null) fc.Dispose();
                    _fontCollections = null;
                }
            };

            Application.Run(new MainForm());
        }

        /// <summary>
        /// This is a method to get the custom font for the program that is embedded in the resources file.
        /// </summary>
        /// <param name="fontData"></param>
        /// <param name="size"></param>
        /// <param name="style"></param>
        /// <returns></returns>
        static public Font GetCustomFont(byte[] fontData, float size, FontStyle style)
        {
            if (_fontCollections == null) _fontCollections = new List<PrivateFontCollection>();
            PrivateFontCollection fontCol = new PrivateFontCollection();
            IntPtr fontPtr = Marshal.AllocCoTaskMem(fontData.Length);
            Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            fontCol.AddMemoryFont(fontPtr, fontData.Length);
            Marshal.FreeCoTaskMem(fontPtr);
            _fontCollections.Add(fontCol);
            return new Font(fontCol.Families[0], size, style);
        }
    }
}
