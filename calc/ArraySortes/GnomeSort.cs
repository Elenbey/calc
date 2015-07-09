namespace calc.Sortes
{
    /// <summary>
    /// class for Gnome sort
    /// </summary>
    public class GnomeSort : ISort
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public double[] Sort(double[] array)
        {
            double tempValue;
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