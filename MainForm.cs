using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Internal;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using Image = System.Drawing.Image;

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

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog.FileName;
            }
        }

        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Bitmaps|*.bmp|jpegs|*.jpg";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.ImageLocation = openFileDialog.FileName;
            }
        }

        private void buttonSAVE_Click(object sender, EventArgs e)
        {
            // postavljanje naziva datoteke koji sadrži datum i vrijeme kreiranja
            string imgName = DateTime.Now.Day + "_" + DateTime.Now.Month + "_" + DateTime.Now.Year + "_h_" + DateTime.Now.Hour + "_" + DateTime.Now.Minute + "_" + DateTime.Now.Second + "." + ImageFormat.Jpeg;
            SaveFileDialog svf = new SaveFileDialog();

            svf.Filter = "Image Files (*.jpeg)|*.jpeg";
            svf.DefaultExt = "jpeg";
            svf.AddExtension = true;
            if (svf.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image.Save(svf.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap bimp = new Bitmap(pictureBox1.Image);
            this.ReplaceColor(bimp, Color.White, Color.Yellow);
            pictureBox2.Image = bimp;

        }
        private void ReplaceColor(Bitmap bitmap, Color originalColor, Color replacementColor)
        {
            for (var y = 0; y < bitmap.Height; y++)
            {
                for (var x = 0; x < bitmap.Width; x++)
                {

                    int redboja = bitmap.GetPixel(x, y).R;
                    int greenboja = bitmap.GetPixel(x, y).G;
                    int blueboja = bitmap.GetPixel(x, y).B;
                    int nr = (int)(redboja);
                    int ng = (int)(greenboja);
                    int nb = (int)(blueboja);
                    //zamjena boja s najjačom bojom
                    //int maxi = Math.Max(Math.Max(nr,ng),nb);
                    //if(maxi==nr)
                    //    bitmap.SetPixel(x, y, Color.FromArgb(255,nr, ng%2, nb%2));
                    //if (maxi == ng)
                    //    bitmap.SetPixel(x, y, Color.FromArgb(255, nr%2 , ng, nb % 2));
                    //if (maxi == nb)
                    //    bitmap.SetPixel(x, y, Color.FromArgb(255, nr % 2, ng % 2, nb));

                    //obrnuti intenziteti
                    //bitmap.SetPixel(x, y, Color.FromArgb(150, 255-nr, 255-ng, 255-nb));

                    //filter intenziteti
                    bitmap.SetPixel(x, y, Color.FromArgb(150, 255 - nr, 255 - ng, 255 - nb));


                }
            }
        }

        private void blurbtn_Click(object sender, EventArgs e)
        {
            Bitmap bimp = new Bitmap(pictureBox1.Image);
            this.BiW(bimp, 150);
            pictureBox2.Image = bimp;
        }
        //SIVI FILTER
        private void BiW(Bitmap bitmap, int alpha)
        {
            for (var y = 0; y < bitmap.Height; y++)
            {
                for (var x = 0; x < bitmap.Width; x++)
                {

                    int redboja = bitmap.GetPixel(x, y).R;
                    int greenboja = bitmap.GetPixel(x, y).G;
                    int blueboja = bitmap.GetPixel(x, y).B;
                    int nr = (int)(redboja);
                    int ng = (int)(greenboja);
                    int nb = (int)(blueboja);
                    int midi = (int)((nr + ng + nb) / 3);
                    if (nr > 127 | ng > 127 | nb > 127)
                        bitmap.SetPixel(x, y, Color.FromArgb(255, midi, midi, midi));
                    else
                        bitmap.SetPixel(x, y, Color.FromArgb(150, 255, 255, 255));


                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap bimp = new Bitmap(pictureBox1.Image);
            this.CIB(bimp, 150);
            pictureBox2.Image = bimp;
        }

        //Crno bijelo FILTER
        private void CIB(Bitmap bitmap, int alpha)
        {
            for (var y = 0; y < bitmap.Height; y++)
            {
                for (var x = 0; x < bitmap.Width; x++)
                {

                    int redboja = bitmap.GetPixel(x, y).R;
                    int greenboja = bitmap.GetPixel(x, y).G;
                    int blueboja = bitmap.GetPixel(x, y).B;
                    int nr = (int)(redboja);
                    int ng = (int)(greenboja);
                    int nb = (int)(blueboja);
                    int midi = (int)((nr + ng + nb) / 3);
                    if (nr < 200 || ng < 200 || nb < 200)
                        bitmap.SetPixel(x, y, Color.FromArgb(midi, 0, 0, 0));
                    else
                        bitmap.SetPixel(x, y, Color.FromArgb(midi, 255, 255, 255));


                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap bimp = new Bitmap(pictureBox1.Image);
            this.ZEL(bimp);
            pictureBox2.Image = bimp;
        }

        private void ZEL(Bitmap bitmap)
        {
            for (var y = 0; y < bitmap.Height; y++)
            {
                for (var x = 0; x < bitmap.Width; x++)
                {

                    int redboja = bitmap.GetPixel(x, y).R;
                    int greenboja = bitmap.GetPixel(x, y).G;
                    int blueboja = bitmap.GetPixel(x, y).B;
                    int nr = (int)(redboja);
                    int ng = (int)(greenboja);
                    int nb = (int)(blueboja);
                    int alpha = Math.Max(Math.Max(nr, ng), nb);
                    int midi = (int)((nr + ng + nb) / 3);

                    if (nr != 255 && ng != 255 && nb != 255)
                        bitmap.SetPixel(x, y, Color.FromArgb(alpha, 0, midi, 0));
                    else
                        bitmap.SetPixel(x, y, Color.FromArgb(255, 255, 255, 255));


                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bitmap bimp = new Bitmap(pictureBox1.Image);
            this.CRV(bimp);
            pictureBox2.Image = bimp;
        }

        private void CRV(Bitmap bitmap)
        {
            for (var y = 0; y < bitmap.Height; y++)
            {
                for (var x = 0; x < bitmap.Width; x++)
                {

                    int nr = bitmap.GetPixel(x, y).R;
                    int ng = bitmap.GetPixel(x, y).G;
                    int nb = bitmap.GetPixel(x, y).B;
                    int alpha = Math.Max(Math.Max(nr, ng), nb);
                    int midi = (int)((nr + ng + nb) / 3);

                    if (nr != 255 && ng != 255 && nb != 255)
                        bitmap.SetPixel(x, y, Color.FromArgb(alpha, midi, 0, 0));
                    else
                        bitmap.SetPixel(x, y, Color.FromArgb(255, 255, 255, 255));


                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bitmap bimp = new Bitmap(pictureBox1.Image);
            this.PLAV(bimp);
            pictureBox2.Image = bimp;
        }

        private void PLAV(Bitmap bitmap)
        {
            for (var y = 0; y < bitmap.Height; y++)
            {
                for (var x = 0; x < bitmap.Width; x++)
                {

                    int nr = bitmap.GetPixel(x, y).R;
                    int ng = bitmap.GetPixel(x, y).G;
                    int nb = bitmap.GetPixel(x, y).B;
                    int alpha = Math.Max(Math.Max(nr, ng), nb);
                    int midi = (int)((nr + ng + nb) / 3);

                    if (nr != 255 && ng != 255 && nb != 255)
                        bitmap.SetPixel(x, y, Color.FromArgb(alpha, 0, 0, midi));
                    else
                        bitmap.SetPixel(x, y, Color.FromArgb(255, 255, 255, 255));


                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Bitmap bimp = new Bitmap(pictureBox1.Image);
            this.PROS(bimp);
            pictureBox2.Image = bimp;
        }
        private void PROS(Bitmap bitmap)
        {
            for (var y = 0; y < bitmap.Height; y++)
            {
                for (var x = 0; x < bitmap.Width; x++)
                {

                    //int nrL = bitmap.GetPixel(x-1, y).R;
                    //int ngL = bitmap.GetPixel(x-1, y).G;
                    //int nbL = bitmap.GetPixel(x-1, y).B;
                    //int nrD = bitmap.GetPixel(x+1, y).R;
                    //int ngD = bitmap.GetPixel(x+1, y).G;
                    //int nbD = bitmap.GetPixel(x+1, y).B;
                    //int nr = (int)((nrL + nrD) / 2);
                    //int ng = (int)((ngL + ngD) / 2);
                    //int nb = (int)((nbL + nbD) / 2);
                    int nr = bitmap.GetPixel(x, y).R;
                    int ng = bitmap.GetPixel(x, y).G;
                    int nb = bitmap.GetPixel(x, y).B;
                    //int alpha = Math.Max(Math.Max(nr, ng), nb);
                    int midi = (int)((nr + ng + nb) / 3);


                    bitmap.SetPixel(x, y, Color.FromArgb(midi, nr / 2, ng / 2, nb / 2));



                }
            }
        }

        private void button7_CrveniNIVO_Click(object sender, EventArgs e)
        {
            Bitmap bimp = new Bitmap(pictureBox1.Image);
            this.CRVENI_oktober(bimp);
            pictureBox2.Image = bimp;
        }

        private void CRVENI_oktober(Bitmap bitmap)
        {
            for (var y = 0; y < bitmap.Height; y++)
            {
                for (var x = 0; x < bitmap.Width; x++)
                {
                    int nr = bitmap.GetPixel(x, y).R;
                    int ng = bitmap.GetPixel(x, y).G;
                    int nb = bitmap.GetPixel(x, y).B;
                    //int alpha = Math.Max(Math.Max(nr, ng), nb);
                    //int midi = (int)((nr + ng + nb) / 3);
                    int alphar = nr;
                    if (nr < 50)
                        alphar = 50;
                    if (nr >= 50 && nr < 100)
                        alphar = 100;
                    if (nr >= 100 && nr < 150)
                        alphar = 150;
                    if (nr >= 150 && nr < 200)
                        alphar = 200;
                    if (nr >= 200 && nr < 250)
                        alphar = 250;


                    bitmap.SetPixel(x, y, Color.FromArgb(alphar, nr, ng, nb));



                }
            }
        }
        //Spajanje snimljenih slika
        private void DUPLOsave_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.Save("C:\\VS_slike\\a.bmp");
            pictureBox2.Image.Save("C:\\VS_slike\\b.bmp");

            Image img1 = Image.FromFile(("C:\\VS_slike\\a.bmp"), true);
            Image img2 = Image.FromFile(("C:\\VS_slike\\b.bmp"), true);


            List<Image> fileList = new List<Image>();
            fileList.Add(img1);
            fileList.Add(img2);

            Bitmap bitmap1 = MergeImagesH(fileList);
            bitmap1.Save(("C:\\VS_slike\\outputH.bmp"), ImageFormat.Jpeg);
        }

        public static Bitmap MergeImagesH(List<Image> images)
        {
            int outputImageWidth = 0;
            int outputImageHeight = 1;
            foreach (Image image in images)
            {
                //HORIZONTALNO
                outputImageWidth += image.Width;
                if (image.Height > outputImageHeight)
                {
                    outputImageHeight = image.Height;
                }
                
            }

            Bitmap outputImage = new Bitmap(outputImageWidth, outputImageHeight, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            using (Graphics graphics = Graphics.FromImage(outputImage))
            {
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                graphics.Clear(Color.White);
                graphics.DrawImage(images[0], new Rectangle(new Point(), images[0].Size), new Rectangle(new Point(), images[0].Size), GraphicsUnit.Pixel);
                graphics.DrawImage(images[1], new Rectangle(new Point(images[0].Width + 1, 0 ), images[1].Size), new Rectangle(new Point(), images[1].Size), GraphicsUnit.Pixel);
            }

            return outputImage;
        }

        public static Bitmap MergeImagesV(List<Image> images)
        {
            int outputImageWidth = 0;
            int outputImageHeight = 1;
            foreach (Image image in images)
            {
                                //VERTIKALNO
                outputImageHeight += image.Height;
                if (image.Width > outputImageWidth)
                {
                    outputImageWidth = image.Width;
                }
            }

            Bitmap outputImage = new Bitmap(outputImageWidth, outputImageHeight, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            using (Graphics graphics = Graphics.FromImage(outputImage))
            {
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                graphics.Clear(Color.White);
                graphics.DrawImage(images[0], new Rectangle(new Point(), images[0].Size), new Rectangle(new Point(), images[0].Size), GraphicsUnit.Pixel);
                graphics.DrawImage(images[1], new Rectangle(new Point(0, images[0].Height + 1), images[1].Size), new Rectangle(new Point(), images[1].Size), GraphicsUnit.Pixel);
            }

            return outputImage;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.Save("C:\\VS_slike\\c.bmp");
            pictureBox2.Image.Save("C:\\VS_slike\\d.bmp");

            Image img1 = Image.FromFile(("C:\\VS_slike\\c.bmp"), true);
            Image img2 = Image.FromFile(("C:\\VS_slike\\d.bmp"), true);


            List<Image> fileList = new List<Image>();
            fileList.Add(img1);
            fileList.Add(img2);

            Bitmap bitmap1 = MergeImagesV(fileList);
            bitmap1.Save(("C:\\VS_slike\\outputV.bmp"), ImageFormat.Jpeg);
        }
    }
}
