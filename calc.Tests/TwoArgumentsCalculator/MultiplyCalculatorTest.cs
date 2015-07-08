using NUnit.Framework;

namespace calc.TwoArgumentsCalculator
{
    [TestFixture]
    public class MultiplyCalculatorTest
    {
        [TestCase(0, 0, 0)]
        [TestCase(3, 4, 12)]
        [TestCase(-7, -2, 14)]
        [TestCase(-7, 2, -14)]
        [TestCase(7, -2, -14)]

        public void CalculateTest(double valueOne, double valueTwo, double result)
        {
            var calculator = new MultiplyCalculator();
            var testResult = calculator.Calculate(valueOne, valueTwo);


            Assert.AreEqual(testResult, result);
        }
    }
}