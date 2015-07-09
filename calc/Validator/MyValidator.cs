using System;
using calc.Helpers;

namespace calc.Validator
{
    public static class MyValidator
    {
        public static double ValidateAndConvertToDouble(string inputString)
        {
            double number;
            bool isDouble = Double.TryParse(inputString, out number);
            if (isDouble)
            {
                return number;
            }
            else
            {
                throw new Exception("Invalid input");
            }
        }

        public static double[] ValidateAndConvertToArray(string input)
        {
            return ArrayHelpers.StringToArray(input, ',');
        }
    }
}
