using NUnit.Framework;

namespace calc.TwoArgumentsCalculator
{
    [TestFixture]
    public class PowerCalculatorTest
    {
        [TestCase(0, 0, 1)]
        [TestCase(3, 2, 9)]
        [TestCase(-1, -2, 1)]
        [TestCase(-1, 2, 1)]
        [TestCase(1, -2, 1)]

        public void CalculateTest(double valueOne, double valueTwo, double result)
        {
            var calculator = new PowerCalculator();
            var testResult = calculator.Calculate(valueOne, valueTwo);


            Assert.AreEqual(testResult, result);
        }
    }
}