using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Bitmap[] Frames;
        private int FrameNum = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Frames = new Bitmap[18];
            for (int j = 0; j < 18; j++)
            {
                Frames[j] = new Bitmap("D:\\Горош Кузя\\Практические 1-17\\PR 11_R\\WindowsFormsApp1\\frames\\Frame" + j + ".png");
            }
            pictureBox1.Image = Frames[FrameNum];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            FrameNum = ++FrameNum % Frames.Length;
            pictureBox1.Image = Frames[FrameNum];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
            if (timer1.Enabled) button1.Text = "Stop";
            else button1.Text = "Start";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = trackBar1.Value;
        }
    }
}
