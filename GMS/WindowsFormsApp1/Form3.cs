using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Gym_Mangement_System
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void showit()
        {
            SqlConnection con = new SqlConnection();


            con.ConnectionString = "Data Source=DESKTOP-GIQC5E8;Initial Catalog=gym;Integrated Security=True";
            con.Open();
            string k = "select * from gymtable";
            SqlCommand cmd = new SqlCommand(k, con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            showit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Deletebutton(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();


            con.ConnectionString = "Data Source=DESKTOP-GIQC5E8;Initial Catalog=gym;Integrated Security=True";
            con.Open();
            string k = "delete from gymtable where id = '" + textBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(k, con);
            cmd.ExecuteNonQuery();
            // DataTable dt = new DataTable();
            // SqlDataAdapter da = new SqlDataAdapter(cmd);
            // da.Fill(dt);
            showit();
            MessageBox.Show("Deleted");







        }
    }
}
