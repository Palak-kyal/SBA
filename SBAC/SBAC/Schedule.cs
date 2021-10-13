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
    public partial class Schedule : Form
    {
        public Schedule()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblinterviewstatus_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String str = "Data Source=DESKTOP-2MJ6I18\\SQLEXPRESS;Initial Catalog=Interview_Track;Integrated Security=True";
            String str1 = "select Name from Interviewers ";
            SqlConnection con = new SqlConnection(str);
            con.Open();
            SqlCommand cmd = new SqlCommand(str1, con);
            SqlDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                cmbinterviewer.Items.Add(dr["Name"]).ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
                {
                    
                }
            }
        }
       
       
            

        }
        
           
     
  
