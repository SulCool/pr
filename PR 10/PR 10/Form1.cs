using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_10
{
    public partial class Form1 : Form
    {
        Rectangle rectangle = new Rectangle(10, 10, 200, 100);
        int x = 0;
        int y = 0;
        Rectangle circle = new Rectangle(220, 10, 150, 150);
        int i = 0;
        int l = 0;
        Rectangle square= new Rectangle(380, 10, 150, 150);
        int s = 0;
        int q = 0;

        int jj, gg, ww, qq;
        int LastClicked = 0;

        bool r = false;
        bool g = false;
        bool b = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(Brushes.Red, circle);
            e.Graphics.FillRectangle(Brushes.Blue, square);
            e.Graphics.FillRectangle(Brushes.Yellow, rectangle);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.X < rectangle.X + rectangle.Width) && (e.X > rectangle.X))
            {
                if ((e.Y < rectangle.Y + rectangle.Height) && (e.Y > rectangle.Y))
                {
                    g = true;
                    x = e.X - rectangle.X;
                    y = e.Y - rectangle.Y;

                    
                }
            }
            if ((e.X < circle.X + circle.Width) && (e.X > circle.X))
            {
                if ((e.Y < circle.Y + circle.Height) && (e.Y > circle.Y))
                {
                    r = true;
                    i = e.X - circle.X;
                    l = e.Y - circle.Y;


                }
            }
            if ((e.X < square.X + square.Width) && (e.X > square.X))
            {
                if ((e.Y < square.Y + square.Height) && (e.Y > square.Y))
                {
                    b = true;
                    s = e.X - square.X;
                    q = e.Y - square.Y;


                }
            }

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {

            if (g)
            {
                rectangle.X = e.X - x;
                rectangle.Y = e.Y - y;
                pictureBox1.Invalidate();
            }
            if (r)
            {
                circle.X = e.X - i;
                circle.Y = e.Y - l;
                pictureBox1.Invalidate();
            }
            if (b)
            {
                square.X = e.X - s;
                square.Y = e.Y - q;
                pictureBox1.Invalidate();
            }
            //int jj, gg, ww, qq;
            LastClicked = 1;
            LastClicked = 2;
            LastClicked = 3;
            if (LastClicked == 1)
            {
                if ((label2.Location.X < circle.X + circle.Width) && (label2.Location.X > circle.X))
                {
                    if ((label2.Location.Y < circle.Y + circle.Height) && (label2.Location.Y > circle.Y))
                    {
                        jj = circle.X;
                        gg = circle.Y;
                        ww = i;
                        qq = l;
                        circle.X = square.X;
                        circle.Y = square.Y;
                        i = s;
                        l = q;
                        square.X = jj;
                        square.Y = gg;
                        s = ww;
                        q = qq;
                    }
                }
            }
            if (LastClicked == 1)
            {
                if ((label2.Location.X < circle.X + circle.Width) && (label2.Location.X > circle.X))
                {
                    if ((label2.Location.Y < circle.Y + circle.Height) && (label2.Location.Y > circle.Y))
                    {
                        jj = circle.X;
                        gg = circle.Y;
                        ww = i;
                        qq = l;
                        circle.X = rectangle.X;
                        circle.Y = rectangle.Y;
                        i = x;
                        l = y;
                        rectangle.X = jj;
                        rectangle.Y = gg;
                        x = ww;
                        y = qq;
                    }
                }
            }
            if (LastClicked == 2)
            {
                if ((label2.Location.X < square.X + square.Width) && (label2.Location.X > square.X))
                {
                    if ((label2.Location.Y < square.Y + square.Height) && (label2.Location.Y > square.Y))
                    {
                        jj = square.X;
                        gg = square.Y;
                        ww = s;
                        qq = q;
                        square.X = circle.X;
                        square.Y = circle.Y;
                        s = i;
                        q = l;
                        circle.X = jj;
                        circle.Y = gg;
                        i = ww;
                        l = qq;
                    }
                }
            }
            if (LastClicked == 2)
            {
                if ((label2.Location.X < square.X + square.Width) && (label2.Location.X > square.X))
                {
                    if ((label2.Location.Y < square.Y + square.Height) && (label2.Location.Y > square.Y))
                    {
                        jj = square.X;
                        gg = square.Y;
                        ww = s;
                        qq = q;
                        square.X = rectangle.X;
                        square.Y = rectangle.Y;
                        s = x;
                        q = y;
                        rectangle.X = jj;
                        rectangle.Y = gg;
                        x = ww;
                        y = qq;
                    }
                }
            }
            if (LastClicked == 3)
            {
                if ((label2.Location.X < rectangle.X + rectangle.Width) && (label2.Location.X > rectangle.X))
                {
                    if ((label2.Location.Y < rectangle.Y + rectangle.Height) && (label2.Location.Y > rectangle.Y))
                    {
                        jj = rectangle.X;
                        gg = rectangle.Y;
                        ww = x;
                        qq = y;
                        rectangle.X = square.X;
                        rectangle.Y = square.Y;
                        x = s;
                        y = q;
                        square.X = jj;
                        square.Y = gg;
                        s = ww;
                        q = qq;
                    }
                }
            }
            if (LastClicked == 3)
            {
                if ((label2.Location.X < rectangle.X + rectangle.Width) && (label2.Location.X > rectangle.X))
                {
                    if ((label2.Location.Y < rectangle.Y + rectangle.Height) && (label2.Location.Y > rectangle.Y))
                    {
                        jj = rectangle.X;
                        gg = rectangle.Y;
                        ww = x;
                        qq = y;
                        rectangle.X = circle.X;
                        rectangle.Y = circle.Y;
                        x = i;
                        y = l;
                        circle.X = jj;
                        circle.Y = gg;
                        i = ww;
                        l = qq;
                    }
                }
            }
            r = false;
            g = false;
            b = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((label1.Location.X < square.X + square.Width) && (label1.Location.X > square.X))
            {
                if ((label1.Location.Y < square.Y + square.Height) && (label1.Location.Y > square.Y))
                {
                    label3.Text = "СИНИЙ КВАДРАТ";

                }
            }
            if ((label1.Location.X < circle.X + circle.Width) && (label1.Location.X > circle.X))
            {
                if ((label1.Location.Y < circle.Y + circle.Height) && (label1.Location.Y > circle.Y))
                {
                    label3.Text = "КРАСНЫЙ КРГ";

                }
            }

            if ((label1.Location.X < rectangle.X + rectangle.Width) && (label1.Location.X > rectangle.X))
            {
                if ((label1.Location.Y < rectangle.Y + rectangle.Height) && (label1.Location.Y > rectangle.Y))
                {
                    label3.Text = "ЖОЛТЫЙ ПРМГЛ";

                }
            }
        }
    }
}
