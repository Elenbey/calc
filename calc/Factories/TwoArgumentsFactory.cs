using System;
using calc.TwoArgumentsCalculator;

namespace calc.Factories
{
    public static class TwoArgumentsFactory
    {
        public static ITwoArgumentsCalculator CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "Addition":
                    return new AdditionCalculator();

                case "Division":
                    return new DivisionCalculator();

                case "Multiply":
                    return new MultiplyCalculator();

                case "Subtraction":
                    return new SubtractionCalculator();

                case "Power":
                    return new PowerCalculator();
                default:
                    throw new Exception("Unknown calculator");
            }
        }
    }
}