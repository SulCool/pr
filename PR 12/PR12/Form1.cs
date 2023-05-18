using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR12
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        public int Det(int[,] A)
        {
            if (A.Length == 1)
                return A[0, 0];
            int S = 0;
            for(int i = 0; i < A.GetLength(0); i++)
            {
                S += Convert.ToInt32(Math.Pow(-1, i)) * A[0, i] * Det(SubMatrix(A, 0, i));
            }
            return S;
        }

        public int[,] SubMatrix(int[,] A, int a, int b)
        {
            int[,] sm = new int[A.GetLength(0) - 1, A.GetLength(1) - 1];
            for (int i = 0; i < sm.GetLength(0); i++)
            {
                for(int j = 0; j < sm.GetLength(1); j++)
                {
                    sm[i, j] = A[i < a ? i : i + 1, j < b ? j : j + 1];
                }
            }
            return sm;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var arr = new int[dataGridView1.RowCount, dataGridView1.ColumnCount];

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    arr[i, j] = rnd.Next(0, 101);
                    dataGridView1.Rows[i].Cells[j].Value = arr[i, j];
                }
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.RowCount = (int)numericUpDown1.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = (int)numericUpDown2.Value;
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            dataGridView2.RowCount = (int)numericUpDown4.Value;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var arr = new int[dataGridView2.RowCount, dataGridView2.ColumnCount];

            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                for (int j = 0; j < dataGridView2.ColumnCount; j++)
                {
                    arr[i, j] = rnd.Next(0, 101);
                    dataGridView2.Rows[i].Cells[j].Value = arr[i, j];
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            dataGridView2.RowCount = dataGridView1.RowCount;
            dataGridView2.ColumnCount = dataGridView1.ColumnCount;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView2[j, i].Value = dataGridView1[j, i].Value;
                }
            }
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            dataGridView2.ColumnCount = (int)numericUpDown3.Value;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = dataGridView2.RowCount;
            dataGridView1.ColumnCount = dataGridView2.ColumnCount;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1[j, i].Value = dataGridView2[j, i].Value;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount != dataGridView2.RowCount)
            {
                if (dataGridView1.ColumnCount != dataGridView2.ColumnCount)
                {
                    MessageBox.Show("АУУУ", "ДЕБИЛ", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            else
            {
                dataGridView3.RowCount = dataGridView1.RowCount;
                dataGridView3.ColumnCount = dataGridView1.ColumnCount;
                dataGridView1.RowCount = dataGridView3.RowCount;
                dataGridView1.ColumnCount = dataGridView3.ColumnCount;
                double sum = 0;

                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        double tempo = 0;
                        double obosrish = 0;
                        tempo = sum + Convert.ToDouble(dataGridView1[i, j].Value);
                        obosrish = tempo + Convert.ToDouble(dataGridView2[i, j].Value);
                        dataGridView3.Rows[j].Cells[i].Value = obosrish;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount != dataGridView2.RowCount)
            {
                if (dataGridView1.ColumnCount != dataGridView2.ColumnCount)
                {
                    MessageBox.Show("АУУУ", "ДЕБИЛ", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            else
            {
                dataGridView3.RowCount = dataGridView1.RowCount;
                dataGridView3.ColumnCount = dataGridView1.ColumnCount;
                dataGridView1.RowCount = dataGridView3.RowCount;
                dataGridView1.ColumnCount = dataGridView3.ColumnCount;

                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        double tempo = 0;
                        double obosrish = 0;
                        tempo = Convert.ToDouble(dataGridView1[i, j].Value);
                        obosrish = tempo - Convert.ToDouble(dataGridView2[i, j].Value);
                        dataGridView3.Rows[j].Cells[i].Value = obosrish;
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount != dataGridView2.RowCount)
            {
                if (dataGridView1.ColumnCount != dataGridView2.ColumnCount)
                {
                    MessageBox.Show("АУУУ", "ДЕБИЛ", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            else
            {
                dataGridView3.RowCount = dataGridView1.RowCount;
                dataGridView3.ColumnCount = dataGridView1.ColumnCount;
                dataGridView1.RowCount = dataGridView3.RowCount;
                dataGridView1.ColumnCount = dataGridView3.ColumnCount;

                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        double tempo = 0;
                        double obosrish = 0;
                        tempo = Convert.ToDouble(dataGridView1[i, j].Value);
                        obosrish = tempo * Convert.ToDouble(dataGridView2[i, j].Value);
                        dataGridView3.Rows[j].Cells[i].Value = obosrish;
                    }
                }
            }
        }

        private void ymn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount != dataGridView2.RowCount)
            {
                if (dataGridView1.ColumnCount != dataGridView2.ColumnCount)
                {
                    MessageBox.Show("АУУУ", "ДЕБИЛ", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            else
            {
                dataGridView3.RowCount = dataGridView1.RowCount;
                dataGridView3.ColumnCount = dataGridView1.ColumnCount;
                dataGridView1.RowCount = dataGridView3.RowCount;
                dataGridView1.ColumnCount = dataGridView3.ColumnCount;

                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        double tempo = 0;
                        double obosrish = 0;
                        tempo = Convert.ToDouble(dataGridView1[i, j].Value);
                        obosrish = tempo * Convert.ToDouble(dataGridView2[i, j].Value);
                        dataGridView3.Rows[j].Cells[i].Value = obosrish;
                    }
                }
            }
        }

        private void ymn1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            dataGridView3.RowCount = dataGridView1.RowCount;
            dataGridView3.ColumnCount = dataGridView1.ColumnCount;
            dataGridView1.RowCount = dataGridView3.RowCount;
            dataGridView1.ColumnCount = dataGridView3.ColumnCount;

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    double tempo = 0;
                    double obosrish = 2;
                    tempo = obosrish * Convert.ToDouble(dataGridView1[i, j].Value);
                    dataGridView3.Rows[j].Cells[i].Value = tempo;
                }
            }

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            dataGridView3.RowCount = dataGridView1.RowCount;
            dataGridView3.ColumnCount = dataGridView1.ColumnCount;
            dataGridView1.RowCount = dataGridView3.RowCount;
            dataGridView1.ColumnCount = dataGridView3.ColumnCount;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    double tempo = 0;
                    double obosrish = 3;
                    tempo = obosrish * Convert.ToDouble(dataGridView1[i, j].Value);
                    dataGridView3.Rows[j].Cells[i].Value = tempo;
                }
            }
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            dataGridView3.RowCount = dataGridView1.RowCount;
            dataGridView3.ColumnCount = dataGridView1.ColumnCount;
            dataGridView1.RowCount = dataGridView3.RowCount;
            dataGridView1.ColumnCount = dataGridView3.ColumnCount;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    double tempo = 0;
                    double obosrish = 4;
                    tempo = obosrish * Convert.ToDouble(dataGridView1[i, j].Value);
                    dataGridView3.Rows[j].Cells[i].Value = tempo;
                }
            }
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            dataGridView3.RowCount = dataGridView1.RowCount;
            dataGridView3.ColumnCount = dataGridView1.ColumnCount;
            dataGridView1.RowCount = dataGridView3.RowCount;
            dataGridView1.ColumnCount = dataGridView3.ColumnCount;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    double tempo = 0;
                    double obosrish = 5;
                    tempo = obosrish * Convert.ToDouble(dataGridView1[i, j].Value);
                    dataGridView3.Rows[j].Cells[i].Value = tempo;
                }
            }
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            dataGridView3.RowCount = dataGridView1.RowCount;
            dataGridView3.ColumnCount = dataGridView1.ColumnCount;
            dataGridView1.RowCount = dataGridView3.RowCount;
            dataGridView1.ColumnCount = dataGridView3.ColumnCount;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    double tempo = 0;
                    double obosrish = 6;
                    tempo = obosrish * Convert.ToDouble(dataGridView1[i, j].Value);
                    dataGridView3.Rows[j].Cells[i].Value = tempo;
                }
            }
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            dataGridView3.RowCount = dataGridView1.RowCount;
            dataGridView3.ColumnCount = dataGridView1.ColumnCount;
            dataGridView1.RowCount = dataGridView3.RowCount;
            dataGridView1.ColumnCount = dataGridView3.ColumnCount;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    double tempo = 0;
                    double obosrish = 7;
                    tempo = obosrish * Convert.ToDouble(dataGridView1[i, j].Value);
                    dataGridView3.Rows[j].Cells[i].Value = tempo;
                }
            }
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            dataGridView3.RowCount = dataGridView1.RowCount;
            dataGridView3.ColumnCount = dataGridView1.ColumnCount;
            dataGridView1.RowCount = dataGridView3.RowCount;
            dataGridView1.ColumnCount = dataGridView3.ColumnCount;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    double tempo = 0;
                    double obosrish = 8;
                    tempo = obosrish * Convert.ToDouble(dataGridView1[i, j].Value);
                    dataGridView3.Rows[j].Cells[i].Value = tempo;
                }
            }
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            dataGridView3.RowCount = dataGridView1.RowCount;
            dataGridView3.ColumnCount = dataGridView1.ColumnCount;
            dataGridView1.RowCount = dataGridView3.RowCount;
            dataGridView1.ColumnCount = dataGridView3.ColumnCount;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    double tempo = 0;
                    double obosrish = 9;
                    tempo = obosrish * Convert.ToDouble(dataGridView1[i, j].Value);
                    dataGridView3.Rows[j].Cells[i].Value = tempo;
                }
            }
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            dataGridView3.RowCount = dataGridView1.RowCount;
            dataGridView3.ColumnCount = dataGridView1.ColumnCount;
            dataGridView1.RowCount = dataGridView3.RowCount;
            dataGridView1.ColumnCount = dataGridView3.ColumnCount;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    double tempo = 0;
                    double obosrish = 10;
                    tempo = obosrish * Convert.ToDouble(dataGridView1[i, j].Value);
                    dataGridView3.Rows[j].Cells[i].Value = tempo;
                }
            }
        }

        private void mior_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount != dataGridView1.ColumnCount)
            {
                MessageBox.Show("Нельзя произвести вычисления!\nМатрица должна быть квадратной!", "Ошибка", MessageBoxButtons.OK);
                return;
            }
            int a = dataGridView1.SelectedCells[0].RowIndex;
            int b = dataGridView1.SelectedCells[0].ColumnIndex;

            int[,] A = new int[dataGridView1.RowCount, dataGridView1.ColumnCount];
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    A[i, j] = Convert.ToInt32(dataGridView1[j, i].Value);
                }
            }
            dataGridView3.RowCount = 2;
            dataGridView3.ColumnCount = 1;
            dataGridView3[0, 0].Value = "Минор элемена матрицы А = ";
            dataGridView3[0, 0].Value = Det(SubMatrix(A, a, b));
        }

        private void button14_Click(object sender, EventArgs e)
        {
            dataGridView2.RowCount = dataGridView3.RowCount;
            dataGridView2.ColumnCount = dataGridView3.ColumnCount;
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                for (int j = 0; j < dataGridView2.ColumnCount; j++)
                {
                    dataGridView2[j, i].Value = dataGridView3[j, i].Value;
                }
            }
        }

        private void transp_Click(object sender, EventArgs e)
        {
            dataGridView3.RowCount = dataGridView1.ColumnCount;
            dataGridView3.ColumnCount = dataGridView1.RowCount;

            for(int i = 0; i < dataGridView3.RowCount; i++)
            {
                for(int j = 0; j < dataGridView3.ColumnCount; j++)
                {
                    dataGridView3[j, i].Value = dataGridView1[i, j].Value;
                }
            }
        }

        private void opred_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount != dataGridView1.ColumnCount)
            {
                MessageBox.Show("Мая щитать квадраный матрица, не прямоугольная", "Конфуз", MessageBoxButtons.OK);
                return;
            }

            int[,] A = new int[dataGridView1.RowCount, dataGridView1.ColumnCount];
            for(int i = 0; i< dataGridView1.RowCount; i++)
            {
                for (int j = 0; j< dataGridView1.ColumnCount; j++)
                {
                    A[i, j] = Convert.ToInt32(dataGridView1[j, i].Value);
                }
            }
            dataGridView3.RowCount = 2;
            dataGridView3.ColumnCount = 1;
            dataGridView3[0, 0].Value = "Гидродезентегратор";
            dataGridView3[0, 1].Value = Det(A);
        }

        private void rag_Click(object sender, EventArgs e)
        {
            dataGridView3.RowCount = 2;
            dataGridView3.ColumnCount = 1;
            int[,] A = new int[dataGridView1.RowCount, dataGridView1.ColumnCount];
            for(int i = 0; i< dataGridView1.RowCount; i++)
            {
                for(int j = 0; j< dataGridView1.ColumnCount; j++)
                {
                    A[i, j] = Convert.ToInt32(dataGridView1[j, i].Value);
                }
            }
            dataGridView3[0, 0].Value = "Улюмулюль";
            dataGridView3[0, 1].Value = Rank(A);
        }

        public int Rank(int[,] matrix)
        {
            int rang = 0;
            int q = 1;

            while (q <=MinValue(matrix.GetLength(0), matrix.GetLength(1)))
            {
                int[,] matbv = new int[q, q];
                for(int i = 0; i < (matrix.GetLength(0) - (q -1)); i++)
                {
                    for (int j = 0; j <(matrix.GetLength(1) - (q - 1)); j++)
                    {
                        for(int k = 0; k < q; k++)
                        {
                            for (int c = 0; c < q; c++)
                            {
                                matbv[k, c] = matrix[i + k, j + c];
                            }
                        }

                        if (Det(matbv) != 0)
                        {
                            rang = q;
                        }
                    }
                }
                q++;
            }

            return rang;
        }

        private int MinValue(int a, int b)
        {
            if (a >= b)
            {
                return b;
            }
            else
            {
            return a;
            }
        }

        private void obr_Click(object sender, EventArgs e)
        {
            dataGridView3.RowCount = dataGridView1.RowCount;
            dataGridView3.ColumnCount = dataGridView1.ColumnCount;
            int[,] M = new int[dataGridView1.ColumnCount, dataGridView1.RowCount];
            int[,] T = new int[dataGridView1.ColumnCount, dataGridView1.RowCount];
            int det;
            if (dataGridView1.RowCount != dataGridView1.ColumnCount)
            {
                MessageBox.Show("Нельзя произвести вычисления!\nМатрица должна быть квадратной!", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            int[,] A = new int[dataGridView1.RowCount, dataGridView1.ColumnCount];
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    A[i, j] = Convert.ToInt32(dataGridView1[j, i].Value);

                }
            }
            //определитель
            det = Det(A);
            if (det == 0)
            {
                MessageBox.Show("Нельзя произвести вычисления!\n Определитель не должен быть равен нулю!", "Ошибка", MessageBoxButtons.OK);
                return;
            }
            //дополнительная матрица
            for (int a = 0; a < dataGridView1.RowCount; a++)
            {
                for (int b = 0; b < dataGridView1.ColumnCount; b++)
                {
                    M[a, b] = (int)Math.Pow(-1, a + b) * Det(SubMatrix(A, b, a));

                }
            }

            for (int i = 0; i < dataGridView3.RowCount; i++)
            {
                for (int j = 0; j < dataGridView3.ColumnCount; j++)
                {
                    T[j, i] = M[i, j];
                }
            }

            //умножаем
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView3[j, i].Value = T[j, i];

                }
            }
            dataGridView3.ColumnCount += 1;
            dataGridView3[dataGridView3.ColumnCount - 1, dataGridView3.RowCount - 1].Value = "* 1 /" + det;
        }
    }
}

