using System;

namespace calc.Validator
{
    public static class _Validator
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

        public static bool ValidateString()
        {
            return false;
        }
    }
}
