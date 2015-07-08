using System;
using System.Linq;

namespace calc.Helpers
{
    public static class ArrayHelpers
    {
        public static int[] StringToArray(string toSplit,char delimiter)
        {
            
            string[] stringItems = toSplit.Split(delimiter);
            int[] result = new int[stringItems.Length];

            for (int i = 0; i < stringItems.Length; i++)
            {
                result[i] = Convert.ToInt32(stringItems[i]);
            }
            return result;
        }

        public static String ArrayToString(int[] array, char delimiter)
        {
           String result = "";

            for (int i = 0; i < array.Length; i++)
            {
                 result += array[i].ToString() + delimiter;
            }

            return result;
           
        }
    }
}