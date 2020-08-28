using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Newmember : Form
    {
        public Newmember()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            string fname = fn.Text;
            string lname = ln.Text;
            string startd = dttb.Text;
            string endd = edtb.Text;
            string pricepaid = pptb.Text;
            string mobilen = mntb.Text;
            string id = idtb.Text;


        /*    //sql connection 
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "";
            SqlDataAdapter DA = SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("New Member Joinded");
        */



        }

     

        
        private void button2_Click(object sender, EventArgs e)
        {
            fn.Clear();
            ln.Clear();
            pptb.Clear();
            edtb.ResetText();
            dttb.ResetText();
            mntb.Clear();
            idtb.Clear();
        }
    }
}
