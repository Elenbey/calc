using System;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace calc
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Calculate(object sender, EventArgs e)
        {
            string senderName = ((Button) sender).Name;
            double calculateResult = 0;

            double firstValue = Convert.ToDouble(ValueOneInput.Text);
            double secondValue = Convert.ToDouble(ValueTwoInput.Text);


            try
            {
                switch (senderName)
                {
                    case "MultiplyButton":
                        calculateResult = firstValue*secondValue;
                        break;
                    case "DivisionButton":
                        if (secondValue == 0)
                        {

                            throw new Exception("Division by zero");
                        }

                        calculateResult = firstValue/secondValue;
                        break;

                    case "AdditionButton":
                        calculateResult = firstValue + secondValue;
                        break;

                    case "SubstractionButton":
                        calculateResult = firstValue - secondValue;
                        break;

                    default:
                        throw new Exception("Unknown operation");

                }
            }
            catch(Exception err)
            {
                OutputField.Text = err.Message.ToString();
                return;
            }

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
            double calculateResult = 0;

            double inputValue = Convert.ToDouble(ValueOneInput.Text);

            switch (senderName)
            {
                case "ModuleButton":
                    calculateResult = Math.Abs(inputValue);
                    break;

                case "CosButton":

                    calculateResult = Math.Cos(inputValue);
                    break;

                case "SinButton":
                    calculateResult = Math.Sin(inputValue);
                    break;

                default:
                    throw new Exception("Unknown operation");

            }

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
