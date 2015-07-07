using System;

namespace calc.TwoArgumentsCalculator
{
    public class PowerCalculator:ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Pow(firstArgument,secondArgument);
        }
    }
}