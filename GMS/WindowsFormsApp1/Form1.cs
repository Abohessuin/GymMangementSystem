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
        }

      
        private void exitAppliction(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}
