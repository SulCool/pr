using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR8
{
    public partial class Colors : Form
    {

        Color colorresult;
        public Colors(Color color)
        {
            InitializeComponent();
            hScrollBar1.Tag = numericUpDown1;
            hScrollBar2.Tag = numericUpDown2;
            hScrollBar3.Tag = numericUpDown3;

            numericUpDown1.Tag = hScrollBar1;
            numericUpDown2.Tag = hScrollBar2;
            numericUpDown3.Tag = hScrollBar3;

            numericUpDown1.Value = color.R;
            numericUpDown2.Value = color.G;
            numericUpDown3.Value = color.B;

            hScrollBar1.Value = color.R;
            hScrollBar2.Value = color.G;
            hScrollBar3.Value = color.B;

        }

        private void Colors_Load(object sender, EventArgs e)
        {

        }
        private void UpdateColor()
        {
            colorresult = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
            pictureBox2.BackColor = colorresult;
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            ScrollBar scrollbar = (ScrollBar)sender;
            NumericUpDown numericUpDown = (NumericUpDown)scrollbar.Tag;
            numericUpDown.Value = scrollbar.Value;
            UpdateColor();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            ScrollBar scrollBar = (ScrollBar)numericUpDown.Tag;
            scrollBar.Value = (int)numericUpDown.Value;
            UpdateColor();
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            ScrollBar scrollbar = (ScrollBar)sender;
            NumericUpDown numericUpDown = (NumericUpDown)scrollbar.Tag;
            numericUpDown.Value = scrollbar.Value;
            UpdateColor();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            ScrollBar scrollBar = (ScrollBar)numericUpDown.Tag;
            scrollBar.Value = (int)numericUpDown.Value;
            UpdateColor();
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            ScrollBar scrollbar = (ScrollBar)sender;
            NumericUpDown numericUpDown = (NumericUpDown)scrollbar.Tag;
            numericUpDown.Value = scrollbar.Value;
            UpdateColor();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            ScrollBar scrollBar = (ScrollBar)numericUpDown.Tag;
            scrollBar.Value = (int)numericUpDown.Value;
            UpdateColor();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ColorDialog clrdlg = new ColorDialog();
            if (clrdlg.ShowDialog() == DialogResult.OK)
            {
                hScrollBar1.Value = clrdlg.Color.R;
                hScrollBar2.Value = clrdlg.Color.G;
                hScrollBar3.Value = clrdlg.Color.B;
                numericUpDown1.Value = clrdlg.Color.R;
                numericUpDown2.Value = clrdlg.Color.G;
                numericUpDown3.Value = clrdlg.Color.B;
                colorresult = clrdlg.Color;
                UpdateColor();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                main.currentPen.Color = colorresult;
            }
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
