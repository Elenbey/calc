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

            double FirstValue = Convert.ToDouble(ValueOneInput.Text);
            double SecondValue = Convert.ToDouble(ValueTwoInput.Text);

            switch (senderName)
            {
                case "MultiplyButton":
                    calculateResult = FirstValue * SecondValue;
                    break;
                case "DivisionButton":
                    if (SecondValue == 0)
                    {
                        throw new Exception("Division by zero");
                    }

                    calculateResult = FirstValue / SecondValue;
                    break;

                case "AdditionButton":
                    calculateResult = FirstValue + SecondValue;
                    break;

                case "SubstractionButton":
                    calculateResult = FirstValue - SecondValue;
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
    }
}
