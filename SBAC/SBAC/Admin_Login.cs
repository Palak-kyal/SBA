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

namespace SBAC
{
    public partial class Admin_Login : Form
    {
        public Admin_Login()
        {
            InitializeComponent();
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = null;
            SqlCommand com = null;
            SqlDataReader dr = null;
            try
            {
                if (!(txtUserName.Text == string.Empty))
                {
                    if (!(txtPassword.Text == string.Empty))
                    {
                        String str = "Data Source=DESKTOP-2MJ6I18\\SQLEXPRESS;Initial Catalog=Interview_Track;Integrated Security=True";
                        String query = "select * from Admin_Login where  User_name= '" + txtUserName.Text + "' and Password= '" + this.txtPassword.Text + "' ";
                        con = new SqlConnection(str);
                        com = new SqlCommand(query, con);
                        con.Open();
                        dr = com.ExecuteReader();
                        int count = 0;
                        while (dr.Read())
                        {
                            count = count + 1;
                        }
                        if (count == 1)
                        {
                            MessageBox.Show("Login Successfull");
                            txtUserName.Clear();
                            txtPassword.Clear();
                            Schedule s = new Schedule();
                            s.ShowDialog();



                        }
                        else if (count > 1)
                        {
                            MessageBox.Show("Duplicate username and password", "login page");
                            txtUserName.Clear();
                            txtPassword.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Credentials", "Login page");
                            txtUserName.Clear();
                            txtPassword.Clear();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Password empty", "Login Page");
                        txtUserName.Clear();
                        txtPassword.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Username empty", "Login Page");
                    txtUserName.Clear();
                    txtPassword.Clear();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void lblRegister_Click(object sender, EventArgs e)
        {

        }
    }
}
