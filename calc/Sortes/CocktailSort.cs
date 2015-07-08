namespace calc.Sortes
{
    public class CocktailSort : ISort
    {
        public int[] Sort(int[] array)
        {
            for (int i = 0; i < array.Length/2; i++)
            {
                bool swapped = false;
                for (int j = i; j < array.Length - i - 1; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        int tmp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = tmp;
                        swapped = true;
                    }
                }
                for (int j = array.Length - 2 - i; j > i; j--)
                {
                    if (array[j] > array[j - 1])
                    {
                        int tmp = array[j];
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


