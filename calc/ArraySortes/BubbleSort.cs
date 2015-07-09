namespace calc.Sortes
{
    /// <summary>
    /// class for Bubble sort
    /// </summary>
    public class BubbleSort : ISort
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public double[] Sort(double[] array)
        {
            int length = array.Length;
            double temp = array[0];
            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            return array;
        }
    }
}