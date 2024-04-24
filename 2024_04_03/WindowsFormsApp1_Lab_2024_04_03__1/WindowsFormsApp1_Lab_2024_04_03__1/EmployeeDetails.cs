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

namespace WindowsFormsApp1_Lab_2024_04_03__1
{
    public partial class EmployeeDetails : Form
    {
        public EmployeeDetails()
        {
            InitializeComponent();
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            string name = addName_tbx.Text;
            string dob = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string email = addEmail_tbx.Text;
            string contactNo = contactNumber_tbx.Text;
            string userName = userName_tbx.Text;
            string password = password_tbx.Text;
            string address = address_tbx.Text;


            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Programming\Github\Repositories - Local\NSBM-Y1S3_C_Sharp_Lab\2024_04_03\WindowsFormsApp1_Lab_2024_04_03__1\WindowsFormsApp1_Lab_2024_04_03__1\Database1.mdf;Integrated Security=True");

            try
            {
                conn.Open();

                string query1 = "INSERT INTO Employee (User_Name, Name, DoB, Password)" +
                    $" VALUES ('{userName}', '{name}', '{dob}', '{password}')";
                string query2 = "INSERT INTO Contact (User_Name, Contact_No, Email, Address)" +
                    $" VALUES ('{userName}', '{contactNo}', '{email}', '{address}')";

                SqlCommand cmd1 = new SqlCommand(query1, conn);
                SqlCommand cmd2 = new SqlCommand(query2,conn);
                {
                    if (!string.IsNullOrEmpty(name) &&
                        !string.IsNullOrEmpty(dob) &&
                        !string.IsNullOrEmpty(email) &&
                        !string.IsNullOrEmpty(contactNo) &&
                        !string.IsNullOrEmpty(userName) &&
                        !string.IsNullOrEmpty(password) &&
                        !string.IsNullOrEmpty(address))
                    {
                        int rowAffected1 = cmd1.ExecuteNonQuery();
                        int rowAffected2 = cmd2.ExecuteNonQuery();

                        if (rowAffected1 > 0 && rowAffected2 > 0)
                        {
                            MessageBox.Show("Successfull", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error:", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Fill all the blanks", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                    
                    
                }


            }
            catch(Exception ex)
            {
                MessageBox.Show("Error:"+ex, "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                Console.WriteLine(ex);
            }
            finally { conn.Close(); }
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            addName_tbx.Text = "";
            dateTimePicker1.Value = DateTime.Today;
            addEmail_tbx.Text = "";
            contactNumber_tbx.Text = "";
            userName_tbx.Text = "";
            password_tbx.Text = "";
            address_tbx.Text = "";
        }
    }
}
