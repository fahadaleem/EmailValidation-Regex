using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

           
                
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label3.Text = "";
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string check = textBox1.Text;
            Regex aa = new Regex("^[a-zA-Z]{1}[a-zA-z0-9./_-]+@(gmail|yahoo|ymail).(co|com)$");
            bool isValid = aa.IsMatch(check);

            label3.Text = isValid ? "Email Validated, it is correct" : "Incorrect Email! Please Write Correct Email";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {

            // Invoice Number Check
            Regex regexPattern = new Regex("^[A-Z]{3}[0-9]{8}$");

            string userChar = textBox2.Text;
            bool isValid = regexPattern.IsMatch(userChar);

            label4.Text = isValid ? "Invoice Valid" : "Invoice Invalid";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Regex regexPattern = new Regex("^[a-zA-Z]{3}[0-9]{8}$");

            string userChar = textBox3.Text;
            bool isValid = regexPattern.IsMatch(userChar);

            label7.Text = isValid ? "Invoice Valid" : "Invoice Invalid";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Website Url Check
            Regex regexPattern = new Regex("^(http|https)://(www){0,1}.[a-zA-Z0-9./_-]+.(co|com)");

            string userChar = textBox4.Text;
            bool isValid = regexPattern.IsMatch(userChar);

            label10.Text = isValid ? "Correct" : "InCorrect";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Regex regexPattern = new Regex("^[0-9]{4}-[0-9]{7}$");

            string userChar = textBox5.Text;
            bool isValid = regexPattern.IsMatch(userChar);

            label13.Text = isValid ? "Correct" : "InCorrect";
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
        
        }

        private void tabPage2_Click_1(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
