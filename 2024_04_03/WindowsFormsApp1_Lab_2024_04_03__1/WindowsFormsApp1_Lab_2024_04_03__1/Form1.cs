using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_Lab_2024_04_03__1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void enterEmployeeDetail_btn_Click(object sender, EventArgs e)
        {
            EmployeeDetails empDetails1 = new EmployeeDetails();
            empDetails1.Show();
            this.Hide();
        }

        private void displayEmployee_btn_Click(object sender, EventArgs e)
        {
            ShowEmployee showEmployee = new ShowEmployee();
            showEmployee.Show();
            this.Hide();
        }
    }
}
