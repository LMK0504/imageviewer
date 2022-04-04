using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        Image Original;
        private double ZOOM_FACTOR = 1.2;
        private int MIN_MAX = 5;
        public Form1()
        {
            InitializeComponent();
            this.MouseWheel += new MouseEventHandler(BaseForm_MouseWheel);
        }

        //private Bitmap PictureBoxReset()
        //{
        //    pictureBox1.Image.Dispose();
        //    pictureBox1.Image = Original.Clone() as Image;
         
        //    Bitmap tmp = pictureBox1.Image as Bitmap;

        //    return tmp;
        //}
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_CallImage_Click(object sender, EventArgs e)
        {
            String file_path = "";
            openFileDialog1.InitialDirectory = "C:\\Users\\moble\\Desktop\\사진";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                file_path = openFileDialog1.FileName;

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile(file_path);
            Original = pictureBox1.Image.Clone() as Image;
           
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btn_Mirror_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
            pictureBox1.Image = pictureBox1.Image;
        }
        private void btn_Rotate_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox1.Image = pictureBox1.Image;
        }
        private void btn_Lotate_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pictureBox1.Image = pictureBox1.Image;
        }
        private void btn_Original_Click(object sender, EventArgs e)
        {

            pictureBox1.Image.Dispose();
            pictureBox1.Image = Original.Clone() as Image;
            pictureBox1.Width = 421;                //픽쳐박스 가로 크기
            pictureBox1.Height = 322;               //픽쳐박스 세로 크기
           
         
        }
        private void btn_Black_Click(object sender, EventArgs e)
        {
            Bitmap tmp = (Bitmap)pictureBox1.Image;

            int width = tmp.Width;
            int height = tmp.Height;

            Color colorData;

            for (int x = 0; x < tmp.Width; x++)
            {
                for (int y = 0; y < tmp.Height; y++)
                {
                    colorData = tmp.GetPixel(x, y);
                    BinaryConvert(ref colorData);
                    tmp.SetPixel(x, y, colorData);
                }
            }
            pictureBox1.Image = tmp;
        }
        private void BinaryConvert(ref Color src)
        {
            if (src.R + src.G + src.B < 382)
            {
                src = Color.FromArgb(0, 0, 0);
            }
            else
            {
                src = Color.FromArgb(255, 255, 255);
            }
        }
        private void GrayConvert(ref Color gry)
        {
            int yrg = (gry.R + gry.G + gry.B) / 3;
            gry = Color.FromArgb(yrg, yrg, yrg);
        }
        private void btn_Gray_Click(object sender, EventArgs e)
        {
            Bitmap tmp = (Bitmap)pictureBox1.Image;

            int width = tmp.Width;
            int height = tmp.Height;

            Color colorData;
            for (int x = 0; x < tmp.Width; x++)
            {
                for (int y = 0; y < tmp.Height; y++)
                {
                    colorData = tmp.GetPixel(x, y);
                    GrayConvert(ref colorData);
                    tmp.SetPixel(x, y, colorData);
                }
            }
            pictureBox1.Image = tmp;
        }
        private void RColorConvert(ref Color red)
        {
            if ((red.R < red.G) || (red.R < red.B))
            {
                int der = (red.R + red.G + red.B) / 3;
                red = Color.FromArgb(der, der, der);
            }
        }
        private void btn_Red_Click(object sender, EventArgs e)
        {
            Bitmap tmp = (Bitmap)pictureBox1.Image;

            int width = tmp.Width;
            int height = tmp.Height;

            Color colorData;
            for (int x = 0; x < tmp.Width; x++)
            {
                for (int y = 0; y < tmp.Height; y++)
                {
                    colorData = tmp.GetPixel(x, y);
                    RColorConvert(ref colorData);
                    tmp.SetPixel(x, y, colorData);
                }
            }
            pictureBox1.Image = tmp;
        }
        private void GColorConvert(ref Color gre)
        {
            if ((gre.G < gre.R) || (gre.G < gre.B))
            {
                int erg = (gre.G + gre.B + gre.R) / 3;
                gre = Color.FromArgb(erg, erg, erg);
            }
        }
        private void btn_Green_Click(object sender, EventArgs e)
        {
            Bitmap tmp = (Bitmap)pictureBox1.Image;

            int width = tmp.Width;
            int height = tmp.Height;

            Color colorData;
            for (int x = 0; x < tmp.Width; x++)
            {
                for (int y = 0; y < tmp.Height; y++)
                {
                    colorData = tmp.GetPixel(x, y);
                    GColorConvert(ref colorData);
                    tmp.SetPixel(x, y, colorData);
                }
            }
            pictureBox1.Image = tmp;
        }
        private void BColorConvert(ref Color blu)
        {
            if ((blu.B < blu.R) || (blu.B < blu.G))
            {
                int ulb = (blu.R + blu.G + blu.B) / 3;
                blu = Color.FromArgb(ulb, ulb, ulb);
            }

        }
        private void btn_Blue_Click(object sender, EventArgs e)
        {
            Bitmap tmp = (Bitmap)pictureBox1.Image;

            int width = tmp.Width;
            int height = tmp.Height;

            Color colorData;
            for (int x = 0; x < tmp.Width; x++)
            {
                for (int y = 0; y < tmp.Height; y++)
                {
                    colorData = tmp.GetPixel(x, y);
                    BColorConvert(ref colorData);
                    tmp.SetPixel(x, y, colorData);
                }
            }
            pictureBox1.Image = tmp;
        }

        private void ZoomIn()

        {
            if ((pictureBox1.Width < (MIN_MAX * pictureBox1.Width)) &&

                (pictureBox1.Height < (MIN_MAX * pictureBox1.Height)))

            {
                pictureBox1.Width = Convert.ToInt32(pictureBox1.Width * ZOOM_FACTOR);
                pictureBox1.Height = Convert.ToInt32(pictureBox1.Height * ZOOM_FACTOR);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;// 여긴 StretchMode 로 해도 상관 없음, zoom으로 하는 경우 화면 배율을 유지하면서 증가
            }
        }
        private void ZoomOut()

        {
            if ((pictureBox1.Width > (pictureBox1.Width / MIN_MAX)) &&

                (pictureBox1.Height > (pictureBox1.Height / MIN_MAX)))

            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // 여긴 StretchMode 로 해도 상관 없음, zoom으로 하는 경우 화면 배율을 유지하면서 증가
                pictureBox1.Width = Convert.ToInt32(pictureBox1.Width / ZOOM_FACTOR);
                pictureBox1.Height = Convert.ToInt32(pictureBox1.Height / ZOOM_FACTOR);
            }
        }
        public void BaseForm_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta <0)
            {
                ZoomIn();
            }
            else
            {
                ZoomOut();
            }
        }
        
    }
}
