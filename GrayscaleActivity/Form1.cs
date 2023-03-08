using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrayscaleActivity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap pic = new Bitmap("C:\\Users\\QQ107\\Pictures\\Banner.jpg");

            pictureBox1.Image = Image.FromFile("C:\\Users\\QQ107\\Pictures\\Banner.jpg");

            for (int y = 0; y < pic.Height; y++)
            {
                for (int x = 0; x < pic.Width; x++)
                {
                    Color c = pic.GetPixel(x, y);

                    int r = c.R;
                    int g = c.G;
                    int b = c.B;
                    int avg = (r + g + b) / 3;
                    pic.SetPixel(x, y, Color.FromArgb(avg, avg, avg));
                }
            }

            pictureBox2.Image = pic;

            pic.Save("C:\\Users\\QQ107\\Pictures\\Banner.jpg");
            }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap alt = new Bitmap("C:\\Users\\QQ107\\Pictures\\Banner.jpg");
            
            pictureBox1.Image = Image.FromFile("C:\\Users\\QQ107\\Pictures\\Banner.jpg");


            Color sight;
            int ret;

            for (int iX = 0; iX < alt.Width; iX++)
            {
                for(int iY = 0; iY < alt.Height; iY++)
                {
                    sight = alt.GetPixel(iX, iY);
                    ret = (int)(sight.R * 0.299 + sight.G * 0.578 + sight.B * 0.114);

                    if (ret > 120)
                    {
                        ret = 255;
                    }
                    else
                    {
                        ret = 0;
                    }
                    alt.SetPixel(iX, iY, Color.FromArgb(ret, ret, ret));
                }
                pictureBox3.Image = alt;

                alt.Save("C:\\Users\\QQ107\\Pictures\\Banner.jpg");
            }
        }
    }
    }

