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
    //user login
    public partial class User_Login : Form
    {
        public User_Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void lblRegister_Click(object sender, EventArgs e)
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
                        String query = "select * from User_Register where  Email = '" + txtUserName.Text + "' and Password= '" + this.txtPassword.Text + "' ";
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

        private void User_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
