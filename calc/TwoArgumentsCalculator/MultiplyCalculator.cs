namespace calc.TwoArgumentsCalculator
{
    /// <summary>
    /// operation multiply
    /// </summary>
    public class MultiplyCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument * secondArgument;
        }
    }
}