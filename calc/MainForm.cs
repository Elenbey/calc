using System;
using System.Linq.Expressions;
using System.Windows.Forms;
using calc.Factories;

namespace calc
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void CalculateTwoArguments(object sender, EventArgs e)
        {
            string senderName = ((Button) sender).Name;
            string operationName = senderName.Replace("Button", "");
            double calculateResult;

            double firstValue = Convert.ToDouble(ValueOneInput.Text);
            double secondValue = Convert.ToDouble(ValueTwoInput.Text);

            calculateResult = TwoArgumentsFactory.CreateCalculator(operationName).Calculate(firstValue,secondValue);


            OutputField.Text = calculateResult.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void CalculateSingleArgument(object sender, EventArgs e)
        {
            string senderName = ((Button)sender).Name;
            string operationName = senderName.Replace("Button", "");

            double calculateResult;

            double inputValue = Convert.ToDouble(ValueOneInput.Text);

            calculateResult = SingleArgumentFactory.CreateCalculator(operationName).Calculate(inputValue);

            OutputField.Text = calculateResult.ToString();
        }

        public MainForm()
        {
            InitializeComponent();
        }



        private void ValueOneInputKeyPress(object sender, KeyPressEventArgs e)
        {
            InputControl(e);
        }

        private void ValueTwoInputKeyPress(object sender, KeyPressEventArgs e)
        {
            InputControl(e);
        }


        public void InputControl(KeyPressEventArgs e)
        {
            char inputSymbol = e.KeyChar;
            if (!Char.IsDigit(inputSymbol) && (inputSymbol != 8 && inputSymbol != 45))
            {
                e.Handled = true;
            }
        }

       
    }
}
