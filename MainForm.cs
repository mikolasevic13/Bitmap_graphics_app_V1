using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bitmap_slika_meta1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnPaint_Click(object sender, EventArgs e)
        {
            Bitmap drawingSurface = new Bitmap(1000, 1000);
            Graphics GFX = Graphics.FromImage(drawingSurface);

            //dijagonalni krugovi
            //GFX.FillEllipse(Brushes.Red, 0, 0, 1000, 1000);
            //GFX.FillEllipse(Brushes.White, 0, 0, 800, 800);
            //GFX.FillEllipse(Brushes.Red, 0, 0, 600, 600);
            //GFX.FillEllipse(Brushes.White, 0, 0, 400, 400);
            //GFX.FillEllipse(Brushes.Red, 0, 0, 200, 200);

            GFX.FillEllipse(Brushes.Red, 0, 0, 1000, 1000);
            GFX.FillEllipse(Brushes.White, 100, 100, 800, 800);
            GFX.FillEllipse(Brushes.Red, 200, 200, 600, 600);
            GFX.FillEllipse(Brushes.White, 300, 300, 400, 400);
            GFX.FillEllipse(Brushes.Red, 400, 400, 200, 200);
            pictureBox1.Image = drawingSurface;
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Bitmaps|*.bmp|jpegs|*.jpg";

            if( openFileDialog.ShowDialog()==DialogResult.OK )
            {
                pictureBox1.ImageLocation = openFileDialog.FileName;
            }
        }
    }
}
