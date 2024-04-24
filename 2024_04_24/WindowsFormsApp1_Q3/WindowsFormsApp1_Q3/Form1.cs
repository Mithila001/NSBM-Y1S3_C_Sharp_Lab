using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_Q3
{
    public partial class Form1 : Form
    {
        SqlConnection connet = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Programming\Github\Repositories - Local\NSBM-Y1S3_C_Sharp_Lab\2024_04_24\WindowsFormsApp1_Q3\WindowsFormsApp1_Q3\Database1.mdf"";Integrated Security=True");
        public Form1()
        {
            InitializeComponent();


        }

        
        private void idVerify_btn_Click(object sender, EventArgs e)
        {
            try
            {
                connet.Open();

                string query = "SELECT EmployeeID, EmployeeName FROM employee WHERE EmployeeID = @EmployeeID";

                using (SqlCommand command = new SqlCommand(query, connet))
                {
                    command.Parameters.AddWithValue("@EmployeeID", textBox1.Text.Trim());

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            string employeeID = reader["EmployeeID"].ToString();
                            string employeeName = reader["EmployeeName"].ToString();

                            textOutput_lbl.Text = "ID Founded:\nID: "+ employeeID + "\nName: "+ employeeName;
                        }
                        else
                        {
                            MessageBox.Show("Employee not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error"+ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                Console.WriteLine(ex);
            }
            finally
            {
                connet.Close();
            }

        }

        private void clearTbx_btn_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
