using System;
using System.Linq;

namespace calc.Helpers
{
    public static class ArrayHelpers
    {
        public static int[] StringToArray(string toSplit,char delimiter)
        {
            if (toSplit.Length == 0)
            {
                throw new Exception("sent an empty string");
            }
            
            string[] stringItems = toSplit.Split(delimiter);
            int[] result = new int[stringItems.Length];

            for (int i = 0; i < stringItems.Length; i++)
            {
                var item = stringItems[i];

                if (item.Length == 0)
                {
                    throw new Exception("sent an crushed string");
                }

                result[i] = Convert.ToInt32(item);
            }
            return result;
        }

        public static String ArrayToString(int[] array, char delimiter)
        {
            if (array.Length == 0)
            {
                throw new Exception("sent an empty array");
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