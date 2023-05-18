using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_6
{
    public partial class Form1 : Form
    {
        private PictureBox[] pbSegments;
        private int numRect = 3;
        private Bitmap Picture;
        public Form1()
        {

            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadPicture();
        }

        private void LoadPicture()
        {
            var ofDlg = new OpenFileDialog();
            ofDlg.Filter = "файлы картинок (*.bmp;*.jpg;*.jpeg;*.gif;)|";
            ofDlg.Filter += "*.bmp;*.jpg;*.jpeg;*.gif|All files (*.*)|*.*";
            ofDlg.FilterIndex = 1;
            ofDlg.RestoreDirectory = true;

            if (ofDlg.ShowDialog() == DialogResult.OK)
            {

                Picture = new Bitmap(ofDlg.FileName);


                CreatePictureSegments();
            }



        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MixedSegments();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            CorrectSizeSegments();
        }

        private void CreatePictureSegments()
        {

            if (pbSegments != null)
            {
                for (int i = 0; i < pbSegments.Length; i++)
                {
                    pbSegments[i].Dispose();
                }
                pbSegments = null;
            }


            pbSegments = new PictureBox[numRect * numRect];


            int w = ClientSize.Width / numRect;
            int h = ClientSize.Height / numRect;


            int countX = 0;
            int countY = 0;

            for (int i = 0; i < pbSegments.Length; i++)
            {
                pbSegments[i] = new PictureBox
                {
                    Width = w,
                    Height = h,
                    Left = countX * w,
                    Top = countY * h
                };
                Point pt = new Point();
                pt.X = pbSegments[i].Left;
                pt.Y = pbSegments[i].Top;


                pbSegments[i].Tag = pt;


                countX++;
                if (countX == numRect)
                {
                    countX = 0;
                    countY++;
                }


                pbSegments[i].Parent = this;
                pbSegments[i].BorderStyle = BorderStyle.None;
                pbSegments[i].SizeMode = PictureBoxSizeMode.StretchImage;


                pbSegments[i].Show();



                pbSegments[i].Click += new EventHandler(button1_Click_1);
            }
            DrawPicture();
        }

        private void MixedSegments()
        {
            if (Picture == null) return;

            Random rand = new Random(Environment.TickCount);

            for (int i = 0; i < pbSegments.Length; i++)
            {
                pbSegments[i].Visible = true;
                int temp = rand.Next(0, pbSegments.Length);
                Point ptR = pbSegments[temp].Location;
                Point ptI = pbSegments[i].Location;
                pbSegments[i].Location = ptR;
                pbSegments[temp].Location = ptI;


                pbSegments[i].BorderStyle = BorderStyle.Fixed3D;
            }
            for(int j = 0; j<pbSegments.Length; j++)
            { 
            int r = rand.Next(0, pbSegments.Length);
            pbSegments[r].Visible = false;
            {
                Point point = (Point)pbSegments[j].Tag;
                if (pbSegments[j].Location != point)
                {
                    return;
                }
            }

            for (int m = 0; m < pbSegments.Length; m++)
            {

                pbSegments[m].Visible = true;


                pbSegments[m].BorderStyle = BorderStyle.None;
            }
            }
        }


        private void CorrectSizeSegments()
        {
            if (pbSegments == null) return;



            int oldwidth = pbSegments[0].Width;
            int oldheight = pbSegments[0].Height;



            int w = ClientSize.Width / numRect;
            int h = ClientSize.Height / numRect;




            for (int i = 0; i < pbSegments.Length; i++)
            {
                pbSegments[i].Width = w;
                pbSegments[i].Height = h;


                int countX = pbSegments[i].Left /= oldwidth;


                int countY = pbSegments[i].Top /= oldheight;


                pbSegments[i].Left = countX * w;
                pbSegments[i].Top = countY * h;

            }
        }
        private void DrawPicture()
        {
            if (Picture == null) return;

            int countX = 0;
            int countY = 0;

            for (int i = 0; i < pbSegments.Length; i++)
            {
                int w = Picture.Width / numRect;
                int h = Picture.Height / numRect;
                pbSegments[i].Image =
                    Picture.Clone(new RectangleF(countX * w, countY * h, w, h),
                        Picture.PixelFormat);
                countX++;
                if (countX == numRect)
                {
                    countX = 0;
                    countY++;
                }
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

