namespace calc.TwoArgumentsCalculator
{
    /// <summary>
    /// operation addition
    /// </summary>
    public class AdditionCalculator:ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument,double secondArgument)
        {
            return firstArgument + secondArgument;
        }
    }
}