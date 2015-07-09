using System;
using calc.Helpers;

namespace calc.Validator
{
    public static class MyValidator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static double[] ValidateAndConvertToArray(string input)
        {
            return ArrayHelpers.StringToArray(input, ',');
        }
    }
}
