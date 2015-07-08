namespace calc.Sortes
{
    public class GnomeSort : ISort
    {
        public int[] Sort(int[] array)
        {
            int tempValue;
            for (int i = 1; i < array.Length; )
            {
                if (array[i - 1] <= array[i])
                    i += 1;
                else
                {
                    tempValue = array[i - 1];
                    array[i - 1] = array[i];
                    array[i] = tempValue;
                    i -= 1;
                    if (i == 0)
                        i = 1;
                }
            }
            return array;
        }
    }
}