using System;

namespace calc.TwoArgumentsCalculator
{
    /// <summary>
    /// operation division
    /// </summary>
    public class DivisionCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            if(secondArgument == 0)
                throw new Exception("Division by zero");
            return firstArgument / secondArgument;
        }
    }
}