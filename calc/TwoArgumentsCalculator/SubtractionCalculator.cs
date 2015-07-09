namespace calc.TwoArgumentsCalculator
{
  
    ///  /// <summary>
    /// operation subtraction
    /// </summary>
 
    public class SubtractionCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument - secondArgument;
        }
    }
}