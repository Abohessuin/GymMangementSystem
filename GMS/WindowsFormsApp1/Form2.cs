using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class DeletedList : Form
    {
        public DeletedList()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();


            con.ConnectionString = "Data Source=DESKTOP-GIQC5E8;Initial Catalog=gym;Integrated Security=True";
            con.Open();
            string k = "select DISTINCT * from deletegymtable";
            SqlCommand cmd = new SqlCommand(k, con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();


            con.ConnectionString = "Data Source=DESKTOP-GIQC5E8;Initial Catalog=gym;Integrated Security=True";
            con.Open();
            string k = "select * from deletegymtable where firstname = " + "'" + textBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(k, con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
