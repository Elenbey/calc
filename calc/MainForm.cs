using System;
using System.Linq.Expressions;
using System.Windows.Forms;
using calc.Factories;
using calc.Helpers;
using calc.SingleArgumentCalculator;
using calc.Sortes;
using calc.TwoArgumentsCalculator;
using calc.Validator;

namespace calc
{

    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void CalculateTwoArguments(object sender, EventArgs e)
        {
            string InputOne = ValueOneInput.Text;
            string InputTwo = ValueTwoInput.Text;

            if (InputOne.Length == 0 || InputTwo.Length == 0)
            {
                throw new Exception("Argument missing");
            }

            string senderName = ((Button) sender).Name;
            string operationName = senderName.Replace("Button", "");

            double firstValue = _Validator.ValidateAndConvertToDouble(ValueOneInput.Text);
            double secondValue = _Validator.ValidateAndConvertToDouble(ValueTwoInput.Text);

            ITwoArgumentsCalculator Calculator = TwoArgumentsFactory.CreateCalculator(operationName);
            var calculateResult = Calculator.Calculate(firstValue,secondValue);
            OutputField.Text = calculateResult.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void CalculateSingleArgument(object sender, EventArgs e)
        {
            string InputOne = ValueOneInput.Text;
            string InputTwo = ValueTwoInput.Text;
            double inputValue;

            if (InputOne.Length == 0)
            {
                if (InputTwo.Length != 0)
                {
                    inputValue = Convert.ToDouble(InputTwo);
                }
                else
                {
                    throw new Exception("Argument missing");
                }
            }
            else
            {
                inputValue = Convert.ToDouble(InputOne); 
            }

            string senderName = ((Button)sender).Name;
            string operationName = senderName.Replace("Button", "");

             ISingleArgumentCalculator Calculator = SingleArgumentFactory.CreateCalculator(operationName);
            var calculateResult = Calculator.Calculate(inputValue);

            OutputField.Text = calculateResult.ToString();
        }

        public void ArraySortes(object sender, EventArgs e)
        {
            string senderName = ((Button)sender).Name;
            string sortName = senderName.Replace("SortButton", "");

            string inputString = ValueOneInput.Text;
            double[] arrayToSort = ArrayHelpers.StringToArray(inputString, ' ');

            ISort ArraySort = ArraySortesFactory.CreateSort(sortName);

            double[] sortedArray = ArraySort.Sort(arrayToSort);
            OutputField.Text = ArrayHelpers.ArrayToString(sortedArray, ' ');
        }



        private void ValueOneInputKeyPress(object sender, KeyPressEventArgs e)
        {
            InputControl(e);
        }

        private void ValueTwoInputKeyPress(object sender, KeyPressEventArgs e)
        {
            InputControl(e);
        }


        public void InputControl( KeyPressEventArgs e)
        {
            char inputSymbol = e.KeyChar;
            if (!Char.IsDigit(inputSymbol) && (inputSymbol != 8 && inputSymbol != '-' && inputSymbol != ',' && inputSymbol != '.'))
            {
                e.Handled = true;
            }
        }

 
       
    }
}
