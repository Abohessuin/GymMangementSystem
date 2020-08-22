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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          //  SearchMember s = new SearchMember();
         //   s.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           
        }
        

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {
           // addMember ad = new addMember();
          //  ad.Show();
        }
        

        private void menuStrip1_ItemClicked_2(object sender, ToolStripItemClickedEventArgs e)
        {
         //   Form4 ad = new Form4();
          //  ad.Show();
        }
        void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
            addMember ad = new addMember();
            ad.Show();
        }

        private void toolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            Form4 ad = new Form4();
            ad.Show();
        }

        private void searchmember(object sender, EventArgs e)
        {
              SearchMember s = new SearchMember();
               s.Show();
        }
    }
}
