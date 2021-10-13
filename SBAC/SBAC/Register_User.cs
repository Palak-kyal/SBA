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
using System.Text.RegularExpressions;


namespace SBAC
{
    public partial class Register_User : Form
    {
        public Register_User()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Register_User_Load(object sender, EventArgs e)
        {
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            SqlConnection con = null;
            SqlCommand com = null;
            //SqlDataReader dr = null;
            Regex rx;
            rx = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");
            //checking validations
            try
            {
                if (!(txtfname.Text == string.Empty))
                {

                    if (!(txtlname.Text == string.Empty))
                    {

                        if (!(cmbusertype.Text.ToString() == string.Empty))
                        {

                            if ((txtmobile.Text != string.Empty && txtmobile.Text.Length == 10))
                            {

                                if (!(txtreport.Text == string.Empty))
                                {


                                    if (!(cmbstatus.Text.ToString() == string.Empty))
                                    {

                                       

                                       if (txtemail.Text != string.Empty && rx.IsMatch(txtemail.Text.Trim()))
                                        {

                                            if (!(txtPass.Text == string.Empty))
                                            {
                                                String str = "Data Source=DESKTOP-2MJ6I18\\SQLEXPRESS;Initial Catalog=Interview_Track;Integrated Security=True";
                                                String query = "insert into User_Register  values('" + txtfname.Text + "', '" + txtlname.Text + "','" + txtemail.Text + "','" + txtmobile.Text + "','" + txtreport.Text + "','" + cmbstatus.Text.ToString() + "','" + cmbusertype.Text.ToString() + "')";
                                                con = new SqlConnection(str);
                                                com = new SqlCommand(query, con);
                                                con.Open();
                                                int i = com.ExecuteNonQuery();
                                                if (i != 0)
                                                {

                                                    MessageBox.Show("Application Submitted");

                                                }
                                                else
                                                {
                                                    MessageBox.Show("Fail to register");
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Enter valid Password");
                                                txtPass.Clear();
                                                txtPass.Focus();


                                            }

                                        }
                                       else
                                       {
                                          MessageBox.Show("Enter valid Email");
                                          txtemail.Clear();
                                          txtemail.Focus();


                                        }
                                        

                                    }
                                    else
                                    {
                                        MessageBox.Show("Enter valid UserStatus");
                                        cmbstatus.SelectedIndex = -1;
                                        cmbstatus.Focus();
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("Enter valid Report");
                                    txtreport.Clear();
                                    txtreport.Focus();
                                }

                            }
                            else
                            {
                                MessageBox.Show("Enter valid Phone number");
                                txtmobile.Clear();
                                txtmobile.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Enter valid User Type");
                            cmbusertype.SelectedIndex = -1;
                            cmbusertype.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter valid LastName");
                        txtlname.Clear();
                        txtlname.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Enter valid FirstName");
                    txtfname.Clear();
                    txtfname.Focus();
                }
            }

            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
