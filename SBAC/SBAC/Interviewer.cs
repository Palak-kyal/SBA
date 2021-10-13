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
    public partial class Interviewer : Form
    {
        public Interviewer()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            SqlConnection con = null;
            SqlCommand com = null;
            //SqlDataReader dr = null;
            
            try
            {
                if (!(txtname.Text == string.Empty))
                {

                    

                        if (!(cmbExp.Text.ToString() == string.Empty))
                        {

                            



                                    if (!(cmbskill.Text.ToString() == string.Empty))
                                    {



                                       
                                            
                                                String str = "Data Source=DESKTOP-2MJ6I18\\SQLEXPRESS;Initial Catalog=Interview_Track;Integrated Security=True";
                                                String query = "insert into Interviewers  values('" + txtname.Text + "', '" + cmbskill.Text.ToString() + "','" + cmbExp.Text.ToString() + "','" + dateTimePicker1.Text + "')";
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
                                        MessageBox.Show("Enter valid Skill");
                                        cmbskill.SelectedIndex = -1;
                                        cmbskill.Focus();
                                    }

                                

                            
                        }
                        else
                        {
                            MessageBox.Show("Enter valid Experience");
                            cmbExp.SelectedIndex = -1;
                            cmbExp.Focus();
                        }
                    
                }
                else
                {
                    MessageBox.Show("Enter valid Name");
                    txtname.Clear();
                    txtname.Focus();
                }
            }

            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void Interviewer_Load(object sender, EventArgs e)
        {

        }
    }
}
