using System;
using System.Windows.Forms;

namespace calc
{
    public partial class MainForm : Form
    {

        public void Calculate(object sender, EventArgs e)
        {
            string senderName = ((Button) sender).Name;
            double calculateResult = 0;

            double firstValue = Convert.ToDouble(ValueOneInput.Text);
            double secondValue = Convert.ToDouble(ValueTwoInput.Text);

            switch (senderName)
            {
                case "MultiplyButton":
                    calculateResult = firstValue * secondValue;
                    break;
                case "DivisionButton":
                    if (secondValue == 0)
                    {
                        throw new Exception("Division by zero");
                    }

                    calculateResult = firstValue / secondValue;
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

            OutputField.Text = calculateResult.ToString();
        }

        public MainForm()
        {
            InitializeComponent();
            ValueOneInput.KeyPress += new KeyPressEventHandler(ValueInputKeyPress);
            ValueTwoInput.KeyPress += new KeyPressEventHandler(ValueInputKeyPress);
        }

        private void ValueInputKeyPress(object sender, KeyPressEventArgs e)
        {
            char introductionSymbols = e.KeyChar;
            if (!Char.IsDigit(introductionSymbols) && introductionSymbols!=8)
            {
                e.Handled = true;
            }
        }
    }
}
