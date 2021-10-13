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
    public partial class Register_Admin : Form
    {
        public Register_Admin()
        {
            InitializeComponent();
        }

        private void lblmobile_Click(object sender, EventArgs e)
        {

        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmobile_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtreport_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtfname_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblreport_Click(object sender, EventArgs e)
        {

        }

        private void lblLname_Click(object sender, EventArgs e)
        {

        }

        private void txtlname_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblemail_Click(object sender, EventArgs e)
        {

        }

        private void lblFname_Click(object sender, EventArgs e)
        {

        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            SqlConnection con = null;
            SqlCommand com = null;
            //SqlDataReader dr = null;
            Regex rx;
            rx = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

            try
            {
                if (!(txtfname.Text == string.Empty))
                {

                    if (!(txtlname.Text == string.Empty))
                    {

                        if (!(txtaddress.Text == string.Empty))
                        {

                            if ((txtmobile.Text != string.Empty && txtmobile.Text.Length == 10))
                            {

                                if (!(txtpass.Text == string.Empty))
                                {



                                        if (txtemail.Text != string.Empty && rx.IsMatch(txtemail.Text.Trim()))
                                        {


                                            String str = "Data Source=DESKTOP-2MJ6I18\\SQLEXPRESS;Initial Catalog=Interview_Track;Integrated Security=True";
                                            String query = "insert into Admin_Rgister  values('" + txtfname.Text + "', '" + txtlname.Text + "','" + txtemail.Text + "','" + txtmobile.Text + "','" + txtaddress.Text + "','" +txtpass.Text + "')";
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
                                            MessageBox.Show("Enter valid Email");
                                            txtemail.Clear();
                                            txtemail.Focus();


                                        }


                                   

                                }
                                else
                                {
                                    MessageBox.Show("Enter valid Password");
                                    txtpass.Clear();
                                    txtpass.Focus();
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
                            MessageBox.Show("Enter valid Address");
                            txtaddress.Clear();
                            txtaddress.Focus();
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

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            Schedule s = new Schedule();
            s.ShowDialog();
        }
    }
    
}
