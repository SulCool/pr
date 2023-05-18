using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace PR_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        public void kish()
        {
            object t;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                for (int j = i + 1; j < listBox1.Items.Count; j++)
                {
                    if (((string)(listBox1.Items[i])).Length > ((string)(listBox1.Items[j])).Length)
                    {
                        t = listBox1.Items[i];
                        listBox1.Items[i] = listBox1.Items[j];
                        listBox1.Items[j] = t;
                    }
                }
            }
        }

        public void kish2()
        {
            object t;
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                for (int j = i + 1; j < listBox2.Items.Count; j++)
                {
                    if (((string)(listBox2.Items[i])).Length > ((string)(listBox2.Items[j])).Length)
                    {
                        t = listBox2.Items[i];
                        listBox2.Items[i] = listBox2.Items[j];
                        listBox2.Items[j] = t;
                    }
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            OpenFileDialog OpenDlg = new OpenFileDialog();
            OpenDlg.Filter = "Текстовые файлы (*.txt)|*.txt|All files(*.*)|*.*";
            if (OpenDlg.ShowDialog() == DialogResult.OK)
            {
                StreamReader Reader = new StreamReader(OpenDlg.FileName, Encoding.Default);
                richTextBox1.Text = Reader.ReadToEnd();
                Reader.Close();
            }
            OpenDlg.Dispose();
        }

        private void сохранитьCtrllSToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

            SaveFileDialog SaveDlg = new SaveFileDialog();
            SaveDlg.Filter = "Текстовые файлы (*.txt)|*.txt|All files(*.*)|*.*";
            if (SaveDlg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter Writer = new StreamWriter(SaveDlg.FileName);
                for (int i = 0; i < listBox2.Items.Count; i++)
                {
                    Writer.WriteLine((string)listBox2.Items[i]);
                }
                Writer.Close();
            }
            SaveDlg.Dispose();
        }

        private void выходAltXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Инфо о приложении и разработчках");
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox3.Items.Clear();

            listBox1.BeginUpdate();
            string[] Strings = richTextBox1.Text.Split(new char[] { '\n', '\t', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string s in Strings)
            {
                string Str = s.Trim();

                if (Str == String.Empty) continue;
                if (radioButton1.Checked) listBox1.Items.Add(Str);
                if (radioButton2.Checked)
                {
                    if (Regex.IsMatch(Str, @"\d")) listBox1.Items.Add(Str);
                }
                if (radioButton3.Checked)
                {
                    if (Regex.IsMatch(Str, @"\w+@\w+\.\w+")) listBox1.Items.Add(Str);
                }
            }
            listBox1.EndUpdate();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            richTextBox1.Clear();
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();

            string Find = textBox1.Text;

            if (checkBox1.Checked)
            {
                foreach (string String in listBox1.Items)
                {
                    if (String.Contains(Find)) listBox3.Items.Add(String); 
                }

            }
            if (checkBox2.Checked)
            {
                foreach (string String in listBox3.Items)
                {
                    if (String.Contains(Find)) listBox3.Items.Add(String);
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form2 AddRec = new Form2();
            AddRec.Owner = this;
            AddRec.ShowDialog();
        }

        public void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        { 

        }

        public void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            ListBox listbox = new ListBox();
            for (int i = listbox.Items.Count - 1; i>=0; i--)
            {
                if (listbox.GetSelected(i)) listbox.Items.RemoveAt(i);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            List<object> s = new List<object>();
            if (comboBox2.SelectedIndex == 0)
            {
                listBox2.Sorted = true;
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                for (int i = 0; i < listBox2.Items.Count; i++)
                {
                    s.Add(listBox2.Items[i]);
                }
                s.Reverse();
                for (int i = 0; i < listBox2.Items.Count; i++)
                {
                    listBox2.Items[i] = s[i];
                }
            }
            else if (comboBox2.SelectedIndex == 2)
            {
                kish2();
            }
            else if (comboBox2.SelectedIndex == 3)
            {
                kish2();
                for (int i = 0; i < listBox2.Items.Count; i++)
                {
                    s.Add(listBox2.Items[i]);
                }
                s.Reverse();
                for (int i = 0; i < listBox2.Items.Count; i++)
                {
                    listBox2.Items[i] = s[i];
                }

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<object> s = new List<object>();
            if (comboBox1.SelectedIndex == 0)
            {
                listBox2.Sorted = true;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    s.Add(listBox1.Items[i]);
                }
                s.Reverse();
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    listBox1.Items[i] = s[i];
                }
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                kish();
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                kish();
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    s.Add(listBox1.Items[i]);
                }
                s.Reverse();
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    listBox1.Items[i] = s[i];
                }

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox2.BeginUpdate();
            foreach (object item in listBox1.SelectedItems)
            {
                listBox2.Items.Add(item);
            }
            listBox2.EndUpdate();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.BeginUpdate();
            foreach (object item in listBox2.SelectedItems)
            {
                listBox1.Items.Add(item);
            }
            listBox1.EndUpdate();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox2.Items.AddRange(listBox1.Items);
            listBox1.Items.Clear();

            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(listBox2.Items);
            listBox2.Items.Clear();
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
    }
