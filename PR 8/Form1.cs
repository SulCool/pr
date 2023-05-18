using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR8
{
    public partial class Form1 : Form
    {
        bool drawing;
        int historyCounter;
        Color historycolor;
        GraphicsPath currentPath;
        Point oldLocation;
        Pen currentPen;
        bool temp = false;
        List<Image> History = new List<Image>();
        public Form1()
        {
            InitializeComponent();
            drawing = false;
            currentPen = new Pen(Color.Black);
            currentPen.Width = trackBar1.Value;
        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openF3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OP = new OpenFileDialog();
            OP.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|GIF Image|*.gif|PNG Image|*.png";
            OP.Title = "Open an Image File";
            OP.FilterIndex = 1;

            if (OP.ShowDialog() != DialogResult.Cancel)
                picDrawingSurface.Load(OP.FileName);
            picDrawingSurface.AutoSize = true;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void newButton2_Click(object sender, EventArgs e)
        {
            Bitmap picture = new Bitmap(750, 500);
            picDrawingSurface.Image = picture;
            if (picDrawingSurface.Image != null)
            {
                var result = MessageBox.Show("Сохранить текущее изображенин перед созданием нового", "fault", MessageBoxButtons.YesNoCancel);
                switch (result)
                {
                    case DialogResult.No: break;
                    case DialogResult.Yes: toolStripButton3_Click(sender, e); break;
                    case DialogResult.Cancel: return;
                }
            }

        }

        private void picDrawingSurface_Click(object sender, EventArgs e)
        {
            if (picDrawingSurface.Image == null)
            {
                MessageBox.Show("Шашлыку нужна загрузить картинка");
                return;
            }
        }

        private void newCtrlNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            History.Clear();
            historyCounter = 0;
            Bitmap pic = new Bitmap(750, 500);
            picDrawingSurface.Image = pic;
            History.Add(new Bitmap(picDrawingSurface.Image));
            if (picDrawingSurface.Image != null)
            {
                var result = MessageBox.Show("Сохранить текущее изображенин перед созданием нового", "fault", MessageBoxButtons.YesNoCancel);
                switch (result)
                {
                    case DialogResult.No: break;
                    case DialogResult.Yes: toolStripButton3_Click(sender, e); break;
                    case DialogResult.Cancel: return;
                }
            }

        }



        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveDlg = new SaveFileDialog();
            SaveDlg.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|GIF Image|*.gif|PNG Image|*.png";
            SaveDlg.Title = "Save an Image File";
            SaveDlg.FilterIndex = 4;
            SaveDlg.ShowDialog();

            if (SaveDlg.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)SaveDlg.OpenFile();
                switch (SaveDlg.FilterIndex)
                {
                    case 1:
                        this.picDrawingSurface.Image.Save(fs, ImageFormat.Jpeg);
                        break;
                    case 2:
                        this.picDrawingSurface.Image.Save(fs, ImageFormat.Bmp);
                        break;
                    case 3:
                        this.picDrawingSurface.Image.Save(fs, ImageFormat.Gif);
                        break;
                    case 4:
                        this.picDrawingSurface.Image.Save(fs, ImageFormat.Png);
                        break;
                }
                fs.Close();

            }

        }

        private void picDrawingSurface_MouseDown(object sender, MouseEventArgs e)
        {
            temp = true;
            if (picDrawingSurface.Image == null)
            {
                MessageBox.Show("Сначала создайе новый файл!");
                return;
            }
            if (e.Button == MouseButtons.Left)
            {
                drawing = true;
                oldLocation = e.Location;
                currentPath = new GraphicsPath();
            }
            if (picDrawingSurface.Image == null)
            {
                MessageBox.Show("Шашлыку нужна загрузить картинка");
                return;
            }
            if (e.Button == MouseButtons.Right)
            {
                historycolor = currentPen.Color;
                currentPen.Color = Color.White;
                drawing = true;
                oldLocation = e.Location;
                currentPath = new GraphicsPath();

            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void openF3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveDlg = new SaveFileDialog();
            SaveDlg.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|GIF Image|*.gif|PNG Image|*.png";
            SaveDlg.Title = "Save an Image File";
            SaveDlg.FilterIndex = 4; //По умолчанке будет png
            SaveDlg.ShowDialog();

            if (SaveDlg.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)SaveDlg.OpenFile();
                switch (SaveDlg.FilterIndex)
                {
                    case 1:
                        this.picDrawingSurface.Image.Save(fs, ImageFormat.Jpeg);
                        break;
                    case 2:
                        this.picDrawingSurface.Image.Save(fs, ImageFormat.Bmp);
                        break;
                    case 3:
                        this.picDrawingSurface.Image.Save(fs, ImageFormat.Gif);
                        break;
                    case 4:
                        this.picDrawingSurface.Image.Save(fs, ImageFormat.Png);
                        break;
                }
                fs.Close();

            }
            if (picDrawingSurface.Image != null)
            {
                var result = MessageBox.Show("Сохранить текущее изображенин перед созданием нового", "fault", MessageBoxButtons.YesNoCancel);
                switch (result)
                {
                    case DialogResult.No: break;
                    case DialogResult.Yes: toolStripButton3_Click(sender, e); break;
                    case DialogResult.Cancel: return;
                }
            }

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            OpenFileDialog OP = new OpenFileDialog();
            OP.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|GIF Image|*.gif|PNG Image|*.png";
            OP.Title = "Open an Image File";
            OP.FilterIndex = 1;

            if (OP.ShowDialog() != DialogResult.Cancel)
                picDrawingSurface.Load(OP.FileName);
            picDrawingSurface.AutoSize = true;

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void openF3ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            History.RemoveRange(historyCounter, History.Count - historyCounter);
            History.Add(new Bitmap(picDrawingSurface.Image));
            if (historyCounter < 1000000) historyCounter++;
            if (History.Count - 1 == 1000000) History.RemoveAt(0);
            if (e.Button == MouseButtons.Right)
            {
                currentPen.Color = historycolor;
            }
            temp = false;
            drawing = false;
            try
            {
                currentPath.Dispose();
            }
            catch { };

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = e.X.ToString() + ", " + e.Y.ToString();
            if (drawing)
            {
                Graphics g = Graphics.FromImage(picDrawingSurface.Image);
                currentPath.AddLine(oldLocation, e.Location);
                g.DrawPath(currentPen, currentPath);
                oldLocation = e.Location;
                g.Dispose();
                picDrawingSurface.Invalidate();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            currentPen.Width = trackBar1.Value;
        }

        private void undoCtrlZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (History.Count != 0 && historyCounter != 0)
            {
                picDrawingSurface.Image = new Bitmap(History[--historyCounter]);
            }
            else MessageBox.Show("история пуста");


        }

        private void renoCtrlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (historyCounter < History.Count - 1)
            {
                picDrawingSurface.Image = new Bitmap(History[++historyCounter]);
            }
            else MessageBox.Show("История пуста");

        }

        private void solidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentPen.DashStyle = DashStyle.Solid;
            solidToolStripMenuItem.Checked = true;
            dotToolStripMenuItem.Checked = false;
            dashNToolStripMenuItem.Checked = false;
        }

        private void dotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentPen.DashStyle = DashStyle.Dot;
            solidToolStripMenuItem.Checked = false;
            dotToolStripMenuItem.Checked = true;
            dashNToolStripMenuItem.Checked = false;
        }

        private void dashNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentPen.DashStyle = DashStyle.DashDotDot;
            solidToolStripMenuItem.Checked = false;
            dotToolStripMenuItem.Checked = false;
            dashNToolStripMenuItem.Checked = true;
        }
    }
}

