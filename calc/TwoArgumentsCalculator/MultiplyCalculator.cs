namespace calc.TwoArgumentsCalculator
{
    public class MultiplyCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument * secondArgument;
        }
    }
}