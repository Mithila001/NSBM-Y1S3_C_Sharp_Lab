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
    public partial class ShowEmployee : Form
    {
        public ShowEmployee()
        {
            InitializeComponent();
        }

        private void ShowEmployee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.database1DataSet.Employee);
            // TODO: This line of code loads data into the 'database1DataSet.Contact' table. You can move, or remove it, as needed.
            this.contactTableAdapter.Fill(this.database1DataSet.Contact);

        }

        private void view_btn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Programming\Github\Repositories - Local\NSBM-Y1S3_C_Sharp_Lab\2024_04_03\WindowsFormsApp1_Lab_2024_04_03__1\WindowsFormsApp1_Lab_2024_04_03__1\Database1.mdf;Integrated Security=True");

            try
            {
                conn.Open();
                string query = "SELECT Employee.User_Name, Employee.Name, Employee.DoB, Employee.Password, Contact.Contact_No, Contact.Email, Contact.Address FROM Employee INNER JOIN Contact ON Employee.User_Name = Contact.User_Name ";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error:" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { conn.Close(); }

            
        }
    }
}
