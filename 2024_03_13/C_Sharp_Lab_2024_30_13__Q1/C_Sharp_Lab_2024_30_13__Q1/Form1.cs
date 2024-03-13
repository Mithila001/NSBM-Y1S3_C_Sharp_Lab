using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace C_Sharp_Lab_2024_30_13__Q1
{
    public partial class Form1 : Form
    {
        int num1;
        int num2;
        String opration;
        int result;
        string resultDisply;

        public Form1()
        {
            InitializeComponent();
            operatorDisplay_lable.Text = ""; // Remove operator display
        }

        private void number_1_btn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender;
            string value = button.Tag.ToString(); // Retrieve the value from the Tag property
            textBoxDisplay.Text += value; // Append the value to the TextBox
        }

        private void number_2_btn_Click_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender;
            string value = button.Tag.ToString();
            textBoxDisplay.Text += value; 
        }

        private void clearDisplay_btn_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = "";
            operatorDisplay_lable.Text = ""; // Remove operator display
        }

        private void addition_btn_Click(object sender, EventArgs e)
        {
            operatorDisplay_lable.Text = "+";

            opration = "+";
            num1 = int.Parse(textBoxDisplay.Text);
            textBoxDisplay.Text = "";
        }
        private void substraction_btn_Click(object sender, EventArgs e)
        {
            operatorDisplay_lable.Text = "-";
            num1 = int.Parse(textBoxDisplay.Text);
            textBoxDisplay.Text = "";
        }
        private void multiplication_btn_Click(object sender, EventArgs e)
        {
            operatorDisplay_lable.Text = "*";
            num1 = int.Parse(textBoxDisplay.Text);
            textBoxDisplay.Text = "";
        }

        private void divition_btn_Click(object sender, EventArgs e)
        {
            operatorDisplay_lable.Text = "/";
            num1 = int.Parse(textBoxDisplay.Text);
            textBoxDisplay.Text = "";
        }

        private void calculateValue_btn_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(textBoxDisplay.Text);

            if(opration == "+")
            {
                result = num1 + num2;
            }

            textBoxDisplay.Text = "";
            resultDisply = result.ToString();
            textBoxDisplay.Text = resultDisply;
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //textBoxDisplay.ReadOnly = true; // Disable direct text input
        }

        private void number_3_btn_Click_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender;
            string value = button.Tag.ToString();
            textBoxDisplay.Text += value;
        }

        private void number_4_btn_Click_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender;
            string value = button.Tag.ToString();
            textBoxDisplay.Text += value;
        }

        private void number_5_btn_Click_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender;
            string value = button.Tag.ToString();
            textBoxDisplay.Text += value;
        }

        private void number_6_btn_Click_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender;
            string value = button.Tag.ToString();
            textBoxDisplay.Text += value;
        }

        private void number_7_btn_Click_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender;
            string value = button.Tag.ToString();
            textBoxDisplay.Text += value;
        }

        private void number_8_btn_Click_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender;
            string value = button.Tag.ToString();
            textBoxDisplay.Text += value;
        }

        private void number_9_btn_Click_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender;
            string value = button.Tag.ToString();
            textBoxDisplay.Text += value;
        }

    }
}
