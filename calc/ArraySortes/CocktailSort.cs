namespace calc.Sortes
{
    /// <summary>
    /// class for Cocktail sort
    /// </summary>
    public class CocktailSort : ISort
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public double[] Sort(double[] array)
        {
            for (int i = 0; i < array.Length/2; i++)
            {
                bool swapped = false;
                for (int j = i; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        double tmp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = tmp;
                        swapped = true;
                    }
                }
                for (int j = array.Length - 2 - i; j > i; j--)
                {
                    if (array[j] < array[j - 1])
                    {
                        double tmp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = tmp;
                        swapped = true;
                    }
                }
                if (!swapped)
                {
                    break;
                }
            }
            return array;
        }
    }
}


