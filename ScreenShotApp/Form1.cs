using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ScreenShotApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = fbd.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                textBox1.Text = fbd.SelectedPath;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Screen screen = Screen.PrimaryScreen;
            int S_width = screen.Bounds.Width;
            int S_height = screen.Bounds.Height;
            Bitmap memoryImage;
            memoryImage = new Bitmap(S_width, S_height);
            Size s = new Size(memoryImage.Width, memoryImage.Height);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(0, 0, 0, 0, s);
            string fileName = string.Format(fbd.SelectedPath +
                      @"\Screenshot" + "_" +
                      DateTime.Now.ToString("(dd_MMMM_hh_mm_ss_tt)") + ".png");
            memoryImage.Save(fileName);
        }
    }
}
