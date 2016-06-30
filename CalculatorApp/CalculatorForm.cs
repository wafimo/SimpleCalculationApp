using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        Calculator aCalculator = new Calculator();

        private void addButton_Click(object sender, EventArgs e)
        {     
            resultTextBox.Text = aCalculator.Add(Convert.ToDouble(firstNumberTextBox.Text), Convert.ToDouble(secondNumberTextBox.Text)).ToString();
        }

        private void subtractionButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = aCalculator.Sub(Convert.ToDouble(firstNumberTextBox.Text), Convert.ToDouble(secondNumberTextBox.Text)).ToString();
        }

        private void multiplicationButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = aCalculator.Mul(Convert.ToDouble(firstNumberTextBox.Text), Convert.ToDouble(secondNumberTextBox.Text)).ToString();
        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = aCalculator.Div(Convert.ToDouble(firstNumberTextBox.Text), Convert.ToDouble(secondNumberTextBox.Text)).ToString();
        }

        
    }
}