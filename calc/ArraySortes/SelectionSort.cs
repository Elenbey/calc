namespace calc.Sortes
{
    public class SelectionSort : ISort
    {
        public double[] Sort(double[] array)
        {
            int posmin;
            double temp;

            for (int i = 0; i < array.Length - 1; i++)
            {
                posmin = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[posmin])
                    {    
                        posmin = j;
                    }
                }
                    if (posmin != i)
                {
                    temp = array[i];
                    array[i] = array[posmin];
                    array[posmin] = temp;
                }
            }
            return array;
        }
    }
}