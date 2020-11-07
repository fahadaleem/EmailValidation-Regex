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

            string check = textBox1.Text;
            Regex aa = new Regex("^[a-zA-Z]{1}[a-zA-z0-9./_-]+@(gmail|yahoo|ymail).(co|com)$");
            bool isValid = aa.IsMatch(check);

            label3.Text = isValid ? "Email Validated, it is correct" : "Incorrect Email! Please Write Correct Email";
                
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label3.Text = "";
        }
    }
}
