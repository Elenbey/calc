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
            try
            {
                string InputOne = ValueOneInput.Text;
                string InputTwo = ValueTwoInput.Text;

                if (InputOne.Length == 0 || InputTwo.Length == 0)
                {
                    throw new Exception("Argument missing");
                }

                string senderName = ((Button) sender).Name;
                string operationName = senderName.Replace("Button", "");

                double firstValue = MyValidator.ValidateAndConvertToDouble(ValueOneInput.Text);
                double secondValue = MyValidator.ValidateAndConvertToDouble(ValueTwoInput.Text);

                ITwoArgumentsCalculator Calculator = TwoArgumentsFactory.CreateCalculator(operationName);
                var calculateResult = Calculator.Calculate(firstValue, secondValue);

                OutputField.Text = calculateResult.ToString();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message, "Error");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void CalculateSingleArgument(object sender, EventArgs e)
        {
            try
            {
                string InputOne = ValueOneInput.Text;
                string InputTwo = ValueTwoInput.Text;
                double inputValue;

                if (InputOne.Length == 0)
                {
                    if (InputTwo.Length == 0)
                    {
                        throw new Exception("Argument missing");
                        inputValue = Convert.ToDouble(InputTwo);
                    }
                    else
                    {
                        inputValue = Convert.ToDouble(InputTwo);
                    }
                }
                else
                {
                    inputValue = Convert.ToDouble(InputOne);
                }

                string senderName = ((Button) sender).Name;
                string operationName = senderName.Replace("Button", "");

                ISingleArgumentCalculator Calculator = SingleArgumentFactory.CreateCalculator(operationName);
                var calculateResult = Calculator.Calculate(inputValue);

                OutputField.Text = calculateResult.ToString();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message, "Error");
            }
        }

        public void ArraySortes(object sender, EventArgs e)
        {
            try
            {
                string senderName = ((Button) sender).Name;
                string sortName = senderName.Replace("SortButton", "");

                string inputString = ValueOneInput.Text;
                double[] arrayToSort = MyValidator.ValidateAndConvertToArray(inputString);

                ISort ArraySort = ArraySortesFactory.CreateSort(sortName);

                double[] sortedArray = ArraySort.Sort(arrayToSort);
                OutputField.Text = ArrayHelpers.ArrayToString(sortedArray, ' ');
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message, "Error");
            }
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
