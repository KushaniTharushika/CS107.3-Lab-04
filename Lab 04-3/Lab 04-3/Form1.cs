using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_04_3
{
    public partial class txtDigit : Form
    {
        public txtDigit()
        {
            InitializeComponent();
        }

        private void butCalculate_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;

            try
            {
                double result = Evaluate(input);
                txtResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                txtResult.Text = "Error: " + ex.Message;
            }
        }

        private double Evaluate(string expression)
        {
            var dataTable = new DataTable();
            var result = dataTable.Compute(expression, "");
            return Convert.ToDouble(result);
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
