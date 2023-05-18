using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace acces
{
    public partial class Form1 : Form
    {
        OleDbConnection con;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
        }

        public void Getstud()
        {
            
                con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=student.accdb");
                da = new OleDbDataAdapter("SELECT *FROM student", con);
                ds = new DataSet();
                con.Open();
                da.Fill(ds, "student");
                dta1.DataSource = ds.Tables["student"];
                con.Close();
            
        

        }

        private void INSERT_Click(object sender, EventArgs e)
        {
            string query = "Insert into student (Name,Newname) values (@fName,@lName)";
            cmd = new OleDbCommand(query, con);
            cmd.Parameters.AddWithValue("@fName", nnm.Text);
            cmd.Parameters.AddWithValue("@lName", newnnm.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Getstud();

        }

        private void del_Click(object sender, EventArgs e)
        {
            string query = "Delete From Student Where ID=@id";
            cmd = new OleDbCommand(query, con);
            cmd.Parameters.AddWithValue("@id", dta1.CurrentRow.Cells[0].Value);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Getstud();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "Update student Set Name=@fName,Newname=@lName Where ID=@id";
            cmd = new OleDbCommand(query, con);
            cmd.Parameters.AddWithValue("@ad", nnm.Text);
            cmd.Parameters.AddWithValue("@soyad", newnnm.Text);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(IDDD.Text));
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Getstud();

        }

        private void dta1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            IDDD.Text = dta1.CurrentRow.Cells[0].Value.ToString();
            nnm.Text = dta1.CurrentRow.Cells[1].Value.ToString();
            newnnm.Text = dta1.CurrentRow.Cells[2].Value.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Getstud();
        }
    }

}
