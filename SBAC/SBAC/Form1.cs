using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBAC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void adminLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin_Login l1 = new Admin_Login();
            l1.Show();
            l1.MdiParent = this;
        }

        private void userLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User_Login l2 = new User_Login();
            l2.Show();
            l2.MdiParent = this;
        }

        private void registerCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Register_User l3 = new Register_User();
            l3.Show();
            l3.MdiParent = this;
        }

        private void registerAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Register_Admin l4 = new Register_Admin();
            l4.Show();
            l4.MdiParent = this;
        }

        private void interviewersToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Interviewer l4 = new Interviewer();
            l4.Show();
            l4.MdiParent = this;

        }
    }
}
