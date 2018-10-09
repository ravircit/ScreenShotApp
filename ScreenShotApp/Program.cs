using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
namespace ScreenShotApp
{
    static class Program
    {
        public static Screen PrimaryScreen { get; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        //[STAThread]
        //static void Main()
        //{
        //Application.EnableVisualStyles();
        //Application.SetCompatibleTextRenderingDefault(false);
        //Application.Run(new Form1());
        //}
        public static void pause()
        {
            Console.Read();
        }
        [STAThread]
        static void Main()
        {
            Application.Run(new Form1());
        }
    }
}
