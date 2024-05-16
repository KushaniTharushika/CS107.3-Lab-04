using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_04_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butCalculate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int num1) && int.TryParse(textBox2.Text, out int num2))
            {

                int result = num1 + num2;


                txtResult.Text = "Result: " + result.ToString();
            }
            else
            {

                MessageBox.Show("Please enter valid numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
