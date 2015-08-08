using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//

using System.IO;



namespace ImageProccessing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public Bitmap Negative(Bitmap bm)
        {
            int x = bm.Width;
            int y = bm.Height;
            
            Bitmap newBitmap = new Bitmap(x,y);


            for (int pixX=0; pixX < x; pixX++)
                {
                    for (int pixY=0; pixY < y; pixY++)
                    {
                        Color CurrentPixel = bm.GetPixel(pixX, pixY);
                        Color TempValue = Color.FromArgb(255-CurrentPixel.R,255-CurrentPixel.G,255-CurrentPixel.B);
                        newBitmap.SetPixel(pixX, pixY, TempValue);
                    }

                }

             return newBitmap;
        }

        public Bitmap Blur(Bitmap bm)
        {
            int x = bm.Width;
            int y = bm.Height;
            double a1 =0.167, a2 = 0.333;

            double a = 0.0, c = 0.0, g = 0.0, k = 0.0;
            double b = a1, d = a1, f = a1, h = a1;
            double e = a2;   

            double sum = a+b+c+d+e+f+h+k;

            Bitmap result = new Bitmap(x, y);

            for (int pixX = 1; pixX < x-2; pixX++)
                for (int pixY = 1; pixY < y-2; pixY++)
                {                  
                    double rd = (a * bm.GetPixel(pixX - 1, pixY - 1).R + b * bm.GetPixel(pixX, pixY - 1).R + c * bm.GetPixel(pixX + 1, pixY - 1).R + d * bm.GetPixel(pixX - 1, pixY).R + e * bm.GetPixel(pixX, pixY).R + f * bm.GetPixel(pixX - 1, pixY + 1).R + g * bm.GetPixel(pixX - 1, pixY + 1).R + h * bm.GetPixel(pixX, pixY + 1).R + k * bm.GetPixel(pixX + 1, pixY + 1).R) / sum;
                    double gr = (a * bm.GetPixel(pixX - 1, pixY - 1).G + b * bm.GetPixel(pixX, pixY - 1).G + c * bm.GetPixel(pixX + 1, pixY - 1).G + d * bm.GetPixel(pixX - 1, pixY).G + e * bm.GetPixel(pixX, pixY).G + f * bm.GetPixel(pixX - 1, pixY + 1).G + g * bm.GetPixel(pixX - 1, pixY + 1).G + h * bm.GetPixel(pixX, pixY + 1).G + k * bm.GetPixel(pixX + 1, pixY + 1).G) / sum;
                    double bl = (a * bm.GetPixel(pixX - 1, pixY - 1).B + b * bm.GetPixel(pixX, pixY - 1).B + c * bm.GetPixel(pixX + 1, pixY - 1).B + d * bm.GetPixel(pixX - 1, pixY).B + e * bm.GetPixel(pixX, pixY).B + f * bm.GetPixel(pixX - 1, pixY + 1).B + g * bm.GetPixel(pixX - 1, pixY + 1).B + h * bm.GetPixel(pixX, pixY + 1).B + k * bm.GetPixel(pixX + 1, pixY + 1).B) / sum;
                    result.SetPixel(pixX, pixY, Color.FromArgb((byte)rd, (byte)gr, (byte)bl));
                }
            return result;           
        }

        public Bitmap Tisn(Bitmap bm)
        {
            int x = bm.Width;
            int y = bm.Height;
            int a1 = 1, a2 = 0, a3 = -4;

            int a = a1, c = a1, g = a1, k = a1;
            int b = a2, d = a2, f = a2, h = a2;
            int e = a3;           

            Bitmap result = new Bitmap(x, y);

            for (int pixX = 1; pixX < x - 2; pixX++)
                for (int pixY = 1; pixY < y - 2; pixY++)
                {
                    int rd = (a * bm.GetPixel(pixX - 1, pixY - 1).R + b * bm.GetPixel(pixX, pixY - 1).R + c * bm.GetPixel(pixX + 1, pixY - 1).R + d * bm.GetPixel(pixX - 1, pixY).R + e * bm.GetPixel(pixX, pixY).R + f * bm.GetPixel(pixX - 1, pixY + 1).R + g * bm.GetPixel(pixX - 1, pixY + 1).R + h * bm.GetPixel(pixX, pixY + 1).R + k * bm.GetPixel(pixX + 1, pixY + 1).R) + 128;
                    int gr = (a * bm.GetPixel(pixX - 1, pixY - 1).G + b * bm.GetPixel(pixX, pixY - 1).G + c * bm.GetPixel(pixX + 1, pixY - 1).G + d * bm.GetPixel(pixX - 1, pixY).G + e * bm.GetPixel(pixX, pixY).G + f * bm.GetPixel(pixX - 1, pixY + 1).G + g * bm.GetPixel(pixX - 1, pixY + 1).G + h * bm.GetPixel(pixX, pixY + 1).G + k * bm.GetPixel(pixX + 1, pixY + 1).G) + 128;
                    int bl = (a * bm.GetPixel(pixX - 1, pixY - 1).B + b * bm.GetPixel(pixX, pixY - 1).B + c * bm.GetPixel(pixX + 1, pixY - 1).B + d * bm.GetPixel(pixX - 1, pixY).B + e * bm.GetPixel(pixX, pixY).B + f * bm.GetPixel(pixX - 1, pixY + 1).B + g * bm.GetPixel(pixX - 1, pixY + 1).B + h * bm.GetPixel(pixX, pixY + 1).B + k * bm.GetPixel(pixX + 1, pixY + 1).B) + 128;
                    if (rd>255 || rd < 0) 
                        rd = 255;

                    if (gr > 255 || gr < 0)
                        gr = 255;

                    if (bl > 255 || bl < 0)
                        bl = 255;

                    result.SetPixel(pixX, pixY, Color.FromArgb(rd, gr, bl));
                }
            return result;
        }


        public Bitmap Rezk(Bitmap bm)
        {
            int x = bm.Width;
            int y = bm.Height;
            int a1 = 0, a2=-1, a3 = 8;

            int a = a1, c = a1, g = a1, k = a1;
            int b = a2, d = a2, f = a2, h = a2;
            int e = a3;
            int sum = a + b + c + d + e + f + h + k;

            Bitmap result = new Bitmap(x, y);

            for (int pixX = 1; pixX < x - 2; pixX++)
                for (int pixY = 1; pixY < y - 2; pixY++)
                {
                    int rd = (a * bm.GetPixel(pixX - 1, pixY - 1).R + b * bm.GetPixel(pixX, pixY - 1).R + c * bm.GetPixel(pixX + 1, pixY - 1).R + d * bm.GetPixel(pixX - 1, pixY).R + e * bm.GetPixel(pixX, pixY).R + f * bm.GetPixel(pixX - 1, pixY + 1).R + g * bm.GetPixel(pixX - 1, pixY + 1).R + h * bm.GetPixel(pixX, pixY + 1).R + k * bm.GetPixel(pixX + 1, pixY + 1).R) / sum;
                    int gr = (a * bm.GetPixel(pixX - 1, pixY - 1).G + b * bm.GetPixel(pixX, pixY - 1).G + c * bm.GetPixel(pixX + 1, pixY - 1).G + d * bm.GetPixel(pixX - 1, pixY).G + e * bm.GetPixel(pixX, pixY).G + f * bm.GetPixel(pixX - 1, pixY + 1).G + g * bm.GetPixel(pixX - 1, pixY + 1).G + h * bm.GetPixel(pixX, pixY + 1).G + k * bm.GetPixel(pixX + 1, pixY + 1).G) / sum;
                    int bl = (a * bm.GetPixel(pixX - 1, pixY - 1).B + b * bm.GetPixel(pixX, pixY - 1).B + c * bm.GetPixel(pixX + 1, pixY - 1).B + d * bm.GetPixel(pixX - 1, pixY).B + e * bm.GetPixel(pixX, pixY).B + f * bm.GetPixel(pixX - 1, pixY + 1).B + g * bm.GetPixel(pixX - 1, pixY + 1).B + h * bm.GetPixel(pixX, pixY + 1).B + k * bm.GetPixel(pixX + 1, pixY + 1).B) / sum;

                    result.SetPixel(pixX, pixY, Color.FromArgb((byte)rd, (byte)gr, (byte)bl));
                }
            return result;
        }

        public Bitmap Okont(Bitmap bm)
        {
            int x = bm.Width;
            int y = bm.Height;
            int a1 = 0, a2 = -1, a3 = 4;

            int a = a1, c = a1, g = a1, k = a1;
            int b = a2, d = a2, f = a2, h = a2;
            int e = a3;
            int sum = a + b + c + d + e + f + h + k;

            Bitmap result = new Bitmap(x, y);

            for (int pixX = 1; pixX < x - 2; pixX++)
                for (int pixY = 1; pixY < y - 2; pixY++)
                {
                    int rd = (a * bm.GetPixel(pixX - 1, pixY - 1).R + b * bm.GetPixel(pixX, pixY - 1).R + c * bm.GetPixel(pixX + 1, pixY - 1).R + d * bm.GetPixel(pixX - 1, pixY).R + e * bm.GetPixel(pixX, pixY).R + f * bm.GetPixel(pixX - 1, pixY + 1).R + g * bm.GetPixel(pixX - 1, pixY + 1).R + h * bm.GetPixel(pixX, pixY + 1).R + k * bm.GetPixel(pixX + 1, pixY + 1).R);
                    int gr = (a * bm.GetPixel(pixX - 1, pixY - 1).G + b * bm.GetPixel(pixX, pixY - 1).G + c * bm.GetPixel(pixX + 1, pixY - 1).G + d * bm.GetPixel(pixX - 1, pixY).G + e * bm.GetPixel(pixX, pixY).G + f * bm.GetPixel(pixX - 1, pixY + 1).G + g * bm.GetPixel(pixX - 1, pixY + 1).G + h * bm.GetPixel(pixX, pixY + 1).G + k * bm.GetPixel(pixX + 1, pixY + 1).G);
                    int bl = (a * bm.GetPixel(pixX - 1, pixY - 1).B + b * bm.GetPixel(pixX, pixY - 1).B + c * bm.GetPixel(pixX + 1, pixY - 1).B + d * bm.GetPixel(pixX - 1, pixY).B + e * bm.GetPixel(pixX, pixY).B + f * bm.GetPixel(pixX - 1, pixY + 1).B + g * bm.GetPixel(pixX - 1, pixY + 1).B + h * bm.GetPixel(pixX, pixY + 1).B + k * bm.GetPixel(pixX + 1, pixY + 1).B);

                    result.SetPixel(pixX, pixY, Color.FromArgb((byte)rd, (byte)gr, (byte)bl));
                }
            return result;
        }

        
        public Bitmap LineContr(Bitmap bm)
        {
            int x = bm.Width;
            int y = bm.Height;

            double x_max = 244.0;//!!!!!!!!!!!!!!!!!!!!!!!!!!!
            double x_min = 0.0;//!!!!!!!!!!!!!!!!!!!!!!!!!!!
            double y_max = 240.0;//!!!!!!!!!!!!!!!!!!!!!!!!!!!
            double y_min = 10.0;//!!!!!!!!!!!!!!!!!!!!!!!!!!!

            Bitmap result = new Bitmap(x, y);

            double d =  (y_max - y_min) + y_min;

            for (int pixX = 0; pixX < x; pixX++)
                for (int pixY = 0; pixY < y; pixY++)
                {
                    double rd = (bm.GetPixel(pixX, pixY).R - x_min) / (x_max - x_min) * d;
                    double gr = (bm.GetPixel(pixX, pixY).G - x_min) / (x_max - x_min) * d;
                    double bl = (bm.GetPixel(pixX, pixY).B - x_min) / (x_max - x_min) * d;

                    result.SetPixel(pixX, pixY, Color.FromArgb((byte)rd, (byte)gr, (byte)bl));
                }

            return result;
        }

        public Bitmap Solyariz(Bitmap bm)
        {
            int x = bm.Width;
            int y = bm.Height;

            double x_max = 244.0;//!!!!!!!!!!!!!!!!!!!!!!!!!!!
            double x_min = 0.0;//!!!!!!!!!!!!!!!!!!!!!!!!!!!
            double y_max = 240.0;//!!!!!!!!!!!!!!!!!!!!!!!!!!!
            double y_min = 10.0;//!!!!!!!!!!!!!!!!!!!!!!!!!!!

            double k = 4/(double)x_max;

            Bitmap result = new Bitmap(x, y);

            for (int pixX = 0; pixX < x; pixX++)
                for (int pixY = 0; pixY < y; pixY++)
                {
                    double rd = k * bm.GetPixel(pixX, pixY).R * (x_max - bm.GetPixel(pixX, pixY).R);
                    double gr = k * bm.GetPixel(pixX, pixY).G * (x_max - bm.GetPixel(pixX, pixY).G);
                    double bl = k * bm.GetPixel(pixX, pixY).B * (x_max - bm.GetPixel(pixX, pixY).B);

                    result.SetPixel(pixX, pixY, Color.FromArgb((byte)rd, (byte)gr, (byte)bl));
                }

            return result;
        }


        public Bitmap Binariz(Bitmap bm)
        {
            int x = bm.Width;
            int y = bm.Height; 

            Bitmap result = new Bitmap(x, y);

            for (int pixX = 0; pixX < x; pixX++)
                for (int pixY = 0; pixY < y; pixY++)
                {

                    int rd, gr, bl;

                    if (bm.GetPixel(pixX, pixY).R  < 100)
                        rd = 0;
                    else
                        rd = 255;

                    if (bm.GetPixel(pixX, pixY).G  < 100)
                        gr = 0;
                    else
                        gr = 255;

                    if (bm.GetPixel(pixX, pixY).B  < 100)
                        bl = 0;
                    else
                        bl = 255;

                    result.SetPixel(pixX, pixY, Color.FromArgb((byte)rd, (byte)gr, (byte)bl));
                }

            return result;
        }


        public Bitmap Binariz2(Bitmap bm)
        {
            int x = bm.Width;
            int y = bm.Height;

            Bitmap result = new Bitmap(x, y);

            double x_max = 244.0;//!!!!!!!!!!!!!!!!!!!!!!!!!!!
            double x_min = 0.0;//!!!!!!!!!!!!!!!!!!!!!!!!!!!
            double y_max = 250.0;//!!!!!!!!!!!!!!!!!!!!!!!!!!!
            double y_min = 0.0;//!!!!!!!!!!!!!!!!!!!!!!!!!!!

            double d = (y_max - y_min) + y_min;

            for (int pixX = 0; pixX < x; pixX++)
                for (int pixY = 0; pixY < y; pixY++)
                {

                    double rd, gr, bl;


                    ///////
                    if (bm.GetPixel(pixX, pixY).R < 50)
                        rd = 0;
                    else if (bm.GetPixel(pixX, pixY).R >= 50 && bm.GetPixel(pixX, pixY).R <= 110)
                        rd = (bm.GetPixel(pixX, pixY).R - x_min) / (x_max - x_min) * d;
                    else
                        rd = 255;

                    ///////
                    if (bm.GetPixel(pixX, pixY).G < 50)
                        gr = 0;
                    else if (bm.GetPixel(pixX, pixY).G >= 50 && bm.GetPixel(pixX, pixY).G <= 110)
                        gr = (bm.GetPixel(pixX, pixY).G - x_min) / (x_max - x_min) * d;
                    else
                        gr = 255;


                    ///////
                    if (bm.GetPixel(pixX, pixY).B < 50)
                        bl = 0;
                    else if (bm.GetPixel(pixX, pixY).B >= 50 && bm.GetPixel(pixX, pixY).B <= 110)
                        bl = (bm.GetPixel(pixX, pixY).B - x_min) / (x_max - x_min) * d;
                    else
                        bl = 255;

                    result.SetPixel(pixX, pixY, Color.FromArgb((byte)rd, (byte)gr, (byte)bl));
                }

            return result;
        }


        public Bitmap resize2(Bitmap bm)
        {
            int x = bm.Width;
            int y = bm.Height;

            Bitmap result = new Bitmap(x/2+1, y/2+1);
            int rx=0, ry=0;
            for (int pixX = 0; pixX < x; pixX = pixX + 2)
            {
     
                for (int pixY = 0 ; pixY < y; pixY = pixY + 2)
                {
                    int red, green, blue;

                    //red
                    red = bm.GetPixel(pixX, pixY).R;

                    //green
                    green = bm.GetPixel(pixX, pixY).G;

                    //blue
                    blue = bm.GetPixel(pixX, pixY).B;

                    result.SetPixel(rx, ry++, Color.FromArgb(red, green, blue));

                }

                rx++;
                ry=0;                
                
            }

            return result;
        }


        private void btnOpenImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog newImgDialog = new OpenFileDialog();
            newImgDialog.Filter = "jpg files (*.jpg)|*.jpg";
            newImgDialog.InitialDirectory = Directory.GetCurrentDirectory();
            newImgDialog.ShowDialog();

            pictureBox1.ImageLocation = newImgDialog.FileName;
        }

        private void btnNegative_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap bm = new Bitmap(pictureBox1.Image);
                pictureBox1.Image = Negative(bm);
                this.Text += " complete";
            }
        }

        private void btnBlure_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap bm = new Bitmap(pictureBox1.Image);
                pictureBox1.Image = Blur(bm);
                this.Text += " complete";
            }
        }

        private void btnTisn_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)            {
                Bitmap bm = new Bitmap(pictureBox1.Image);
                pictureBox1.Image = Tisn(bm);
                this.Text += " complete";
            }

        }

        private void bntRezkost_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap bm = new Bitmap(pictureBox1.Image);
                pictureBox1.Image = Rezk(bm);
                this.Text += " complete";
            }
        }

        private void btnOkontur_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap bm = new Bitmap(pictureBox1.Image);
                pictureBox1.Image = Okont(bm);
                this.Text += " complete";
            }
        }

        private void btnLineContr_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap bm = new Bitmap(pictureBox1.Image);
                pictureBox1.Image = LineContr(bm);
                this.Text += " complete";
            }
        }

        private void btnSolyariz_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap bm = new Bitmap(pictureBox1.Image);
                pictureBox1.Image = Solyariz(bm);
                this.Text += " complete";
            }
        }

        private void btnBinariz_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap bm = new Bitmap(pictureBox1.Image);
                pictureBox1.Image = Binariz(bm);
                this.Text += " complete";
            }
        }

        private void btnBinariz2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap bm = new Bitmap(pictureBox1.Image);
                pictureBox1.Image = Binariz2(bm);
                this.Text += " complete";
            }
        }

        private void btnReloadImg_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "IMG0389.jpg";
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            string str_loc_img = pictureBox1.ImageLocation;
            Bitmap i = new Bitmap(pictureBox1.Image);
            i.Save(str_loc_img + "new.jpg");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap bm = new Bitmap(pictureBox1.Image);
                pictureBox1.Image = resize2(bm);
                this.Text += " complete";
            }
        }
    }
}
