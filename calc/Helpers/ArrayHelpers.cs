using System;
using System.Linq;
using calc.Validator;

namespace calc.Helpers
{
    /// <summary>
    /// class ArrayHelpers
    /// </summary>
    public static class ArrayHelpers
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="toSplit"></param>
        /// <param name="delimiter"></param>
        /// <returns></returns>
        public static double[] StringToArray(string toSplit,char delimiter)
        {
            if (toSplit.Length == 0)
            {
                throw new Exception("Sent an empty string");
            }
            
            string[] stringItems = toSplit.Split(delimiter);
            double[] result = new double[stringItems.Length];

            for (int i = 0; i < stringItems.Length; i++)
            {
                var item = stringItems[i];

                if (item.Length == 0)
                {
                    throw new Exception("Sent an crushed string");
                }

                result[i] = MyValidator.ValidateAndConvertToDouble(item);
            }
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="array"></param>
        /// <param name="delimiter"></param>
        /// <returns></returns>
        public static String ArrayToString(double[] array, char delimiter)
        {
            if (array.Length == 0)
            {
                throw new Exception("Sent an empty array");
            }
            String result = "";

            for (int i = 0; i < array.Length; i++)
            {
                result += array[i].ToString();
                if (i < array.Length - 1)
                {
                    result += delimiter;
                }
            }

            return result;
           
        }
    }
}