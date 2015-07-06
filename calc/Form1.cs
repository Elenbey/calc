using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {
        public double ValueOne;
        public double ValueTwo;
        public double Result;

        
        public Form1()
        {
            InitializeComponent();
        }

        private void InputLableClick(object sender, EventArgs e)
        {

        }

        private void ValueOneInputTextChanged(object sender, EventArgs e)
        {
            string input = ValueOneInput.Text;
            if (input.Length == 0)
            {
                ValueOne = 0;
            }
            else
            {
                ValueOne = Convert.ToDouble(input);
            }
            
        }

        private void ValueTwoInputTextChanged(object sender, EventArgs e)
        {
            string input = ValueTwoInput.Text;
            if (input.Length == 0)
            {
                ValueTwo = 0;
            }

            else
            {
                ValueTwo = Convert.ToDouble(input);
            }
                
        }

        public void ParseInput(string argument)
        {
         
        }

        private void OutputFieldTextChanged(object sender, EventArgs e)
        {
            
        }

        private void MultiplyButtonClick(object sender, EventArgs e)
        {
            Result = ValueOne * ValueTwo;
            OutputField.Text = Result.ToString();
            Reset();

        }

        private void DivisionButtonClick(object sender, EventArgs e)
        {
            if (ValueTwo == 0)
            {
                MessageBox.Show("Division by zero", "Error");
                return;
            }
                
            Result = ValueOne  / ValueTwo;
            OutputField.Text = Result.ToString();
            Reset();

        }

        private void AdditionButtonClick(object sender, EventArgs e)
        {
            Result = ValueOne + ValueTwo;
            OutputField.Text = Result.ToString();
            Reset();

        }

        private void SubstractionButtonClick(object sender, EventArgs e)
        {
           Result =ValueOne - ValueTwo;
           OutputField.Text = Result.ToString();
            Reset();
        }

        public void Reset()
        {
            ValueOneInput.Text = "";
            ValueTwoInput.Text = "";
        }


        

    }
}
