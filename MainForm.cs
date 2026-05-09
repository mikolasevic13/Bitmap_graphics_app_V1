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
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using static System.Net.Mime.MediaTypeNames;


using Image = System.Drawing.Image;

namespace Bitmap_slika_meta1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        //random input image klika na gumb Random image - input image

        public string abeceda = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ.,!:=/$%;0123456789ŠĐČĆŽšđčćž?()#$%&?+-*_-<>";

        private void btnPaint_Click(object sender, EventArgs e)
        {

            Bitmap bimp = new Bitmap(800, 800);
            for (int i = 0; i < 800; i++)
                for (int j = 0; j < 800; j++)
                    bimp.SetPixel(i, j, Color.White);
            this.pictureBox1.Image = bimp;


            
            for (int x = 0; x < bimp.Width; x++)
                for (int y = 0; y < bimp.Height; y++)
                {
                    Random r = new Random(Guid.NewGuid().GetHashCode());

                    int rand_red = r.Next(0, 5000);
                    rand_red = rand_red % 255;
                    int rand_green = r.Next(0, 5000);
                    rand_green = rand_green % 255;
                    int rand_blue = r.Next(0, 5000);
                    rand_blue = rand_blue % 255;
                    bimp.SetPixel(x, y, Color.FromArgb(255, rand_red, rand_green, rand_blue));
                }
                    
            bimp.Save("C:\\VS_slikeOUT\\rand_image.bmp");
            this.pictureBox1.Image = bimp;

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            Bitmap bimp = new Bitmap(800, 800);
            bimp = (Bitmap)pictureBox1.Image;
            string original = textBox1.Text;
            string abeceda = " abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ.,!:=/$%;0123456789ŠĐČĆŽšđčćž?()#$%&?+-*_-<>";

            Bitmap codedbit = new Bitmap(800, 800);

            int i=0,j=0;
            int br_znak=0;
            int[] pomak= new int[800];
            
            for (i = 0; i < 800; i++)
            {
                br_znak = 0;
                if (i < original.Length)
                {
                    char znak = original[i];
                    for(j=0;j<abeceda.Length;j++)
                    {
                        if (znak == abeceda[j])
                            br_znak = j + 65;
                    }
                    pomak[i] = br_znak;
                }
                else
                    pomak[i] = 0;

            }
            /*ispis u textbox proba
            for (i = 0; i < 800; i++)
            {
                textBox2.Text += pomak[i]+" ";

            }
            */

            for (int y = 0; y < 800; y++)
            {
                    for (int x = 0; x < 800; x++)
                    {
                        int r = bimp.GetPixel(x, y).R;
                        int g = bimp.GetPixel(x, y).G;
                        int b = bimp.GetPixel(x, y).B;
                    if ((x == pomak[y]) & (y< original.Length))
                    {
                        if(y%3==0)
                        {
                            if (r > 1)
                                codedbit.SetPixel(x, y, Color.FromArgb(255, r - 1, g, b));
                            else
                                codedbit.SetPixel(x, y, Color.FromArgb(255, r + 1, g, b));
                            if (r < 255)
                                codedbit.SetPixel(x, y, Color.FromArgb(255, r + 1, g, b));
                        }
                            
                        if (y % 3 == 1)
                        {
                            if (g > 1) 
                                codedbit.SetPixel(x, y, Color.FromArgb(255, r , g-1, b));
                            else
                                codedbit.SetPixel(x, y, Color.FromArgb(255, r, g + 1, b));
                            if (g < 255)
                                codedbit.SetPixel(x, y, Color.FromArgb(255, r , g+1, b));
                        }
                        codedbit.SetPixel(x, y, Color.FromArgb(255, r, g-1, b));
                        if (y % 3 == 2)
                        {
                            if (b > 1) 
                                codedbit.SetPixel(x, y, Color.FromArgb(255, r , g, b-1));
                            else
                                codedbit.SetPixel(x, y, Color.FromArgb(255, r, g, b + 1));
                            if (b < 255)
                                codedbit.SetPixel(x, y, Color.FromArgb(255, r , g, b+1));
                        }
                        
                    }
                    else
                        {
                            codedbit.SetPixel(x, y, Color.FromArgb(255, r, g, b));
                        }

                    }
                
            }

            codedbit.Save("C:\\VS_slikeOUT\\code_image.bmp");
            this.pictureBox2.Image = codedbit;
        }
        //DEKODIRANJE IZ SLIKE
        private void DECODE_A_Click(object sender, EventArgs e)
        {

            

            //Bitmap bimp = new Bitmap(@"C:\\VS_slike\\outputH.bmp",true);
            Bitmap bimp = (Bitmap)pictureBox1.Image;
            string im1, im2;
            string abeceda = " abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ.,!:=/$%;0123456789ŠĐČĆŽšđčćž?()#$%&?+-*_-<>";
            char deznak=' ';
            int i = 0, j = 0,x,y;
            int br_znak;
            int prazno=0;
            int[] pomak = new int[800];
            int kontrol = 0;
            
            //PRONAĐI I POKUPI RAZLIKE U INTENZITETIMA...
            //VEKTOR DEKODIRAN POMAK[Y]
            for ( y = 0; y < 800; y++)
            {
                kontrol = 0;
                for ( x = 0; x < 800; x++)
                {
                    Color pix1 = bimp.GetPixel(x, y);
                    Color pix2 = bimp.GetPixel(x+800, y);
                    int r = (int)pix1.R;
                    int g = (int)pix1.G;
                    int b = (int)pix1.B;
                    int rd = (int)pix2.R;
                    int gd = (int)pix2.G;
                    int bd = (int)pix2.B;
                    
                    if (pix1!=pix2)
                    {
                        pomak[y] = x;
                        kontrol++;
                        break;
                    }
                    else
                    {
                        pomak[y] = 0;
                    }
                }
                

            }
            //DEKODIRATI IZ INT U CHAR ZNAK PO ZNAK POMAK[Y]
            string dekod="";
            for(i=0;i<800;i++)
            {
                if (pomak[i] != 0)
                {
                    br_znak = pomak[i];
                    deznak = abeceda[br_znak-65];
                }
                else
                    deznak = ' ';
                textBox2.Text += deznak;
            }
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

        //Spajanje snimljenih slika HORIZONTALNO
        private void DUPLOsave_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.Save("C:\\VS_slikeOUT\\a.bmp");
            pictureBox2.Image.Save("C:\\VS_slikeOUT\\b.bmp");

            Image img1 = Image.FromFile(("C:\\VS_slikeOUT\\a.bmp"), true);
            Image img2 = Image.FromFile(("C:\\VS_slikeOUT\\b.bmp"), true);


            List<Image> fileList = new List<Image>();
            fileList.Add(img1);
            fileList.Add(img2);

            Bitmap bitmap1 = MergeImagesH(fileList);
            bitmap1.Save(("C:\\VS_slikeOUT\\outputH.bmp"), ImageFormat.Bmp);
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
                graphics.DrawImage(images[1], new Rectangle(new Point(images[0].Width, 0 ), images[1].Size), new Rectangle(new Point(), images[1].Size), GraphicsUnit.Pixel);
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
                graphics.DrawImage(images[1], new Rectangle(new Point(0, images[0].Height), images[1].Size), new Rectangle(new Point(), images[1].Size), GraphicsUnit.Pixel);
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
            bitmap1.Save(("C:\\VS_slike\\outputV.bmp"), ImageFormat.Bmp);
        }
    }
}
