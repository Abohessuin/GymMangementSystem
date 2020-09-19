using Gym_Mangement_System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

             
        void addNewMember(object sender, EventArgs e)
        {
            
            Newmember ad = new Newmember();
            ad.Show();
        }

        private void deleteMember(object sender, EventArgs e)
        {
            Form4 ad = new Form4();
            ad.Show();
        }
     
        private void searchMember(object sender, EventArgs e)
        {
              SearchMember s = new SearchMember();
               s.Show();

            SqlConnection conn = new SqlConnection();


            conn.ConnectionString = "Data Source=DESKTOP-GIQC5E8;Initial Catalog=gym;Integrated Security=True";
            conn.Open();
            string kk = "INSERT INTO deletegymtable select * from gymtable where(SELECT FORMAT (getdate(), 'MM/dd/yyyy ')   ) > (SELECT CAST(enddate AS datetime))";
            SqlCommand cmdd = new SqlCommand(kk, conn);
            cmdd.ExecuteNonQuery();
            DataTable dtt = new DataTable();
            SqlDataAdapter daa = new SqlDataAdapter(cmdd);
            daa.Fill(dtt);





            SqlConnection con = new SqlConnection();


            con.ConnectionString = "Data Source=DESKTOP-GIQC5E8;Initial Catalog=gym;Integrated Security=True";
            con.Open();
            string k = "delete from gymtable where ( SELECT FORMAT (getdate(), 'MM/dd/yyyy ')   ) > ( SELECT CAST(enddate AS datetime))";
            SqlCommand cmd = new SqlCommand(k, con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);


           

        }

      
        private void exitAppliction(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

           





          //  SqlConnection con = new SqlConnection();


         //   con.ConnectionString = "Data Source=DESKTOP-GIQC5E8;Initial Catalog=gym;Integrated Security=True";
         //   con.Open();
         //   string k = "delete from gymtable where ( SELECT FORMAT (getdate(), 'MM/dd/yyyy ')   ) > ( SELECT CAST(enddate AS datetime))";
         //   SqlCommand cmd = new SqlCommand(k, con);
        //    cmd.ExecuteNonQuery();
        //    DataTable dt = new DataTable();
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    da.Fill(dt);


         

            //MessageBox.Show("New Member Joinded");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeletedList l = new DeletedList();
            l.Show();

        }
    }
}
