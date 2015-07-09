using calc.TwoArgumentsCalculator;
using NUnit.Framework;

namespace calc.Tests.TwoArgumentsCalculatorTests
{
    [TestFixture]
    public class AdditionCalculatorTest
    {
        [TestCase(0, 0, 0)]
        [TestCase(3, 4, 7)]
        [TestCase(-7, -2, -9)]
        public void CalculateTest(double valueOne,double valueTwo, double result)
        {
            var calculator = new AdditionCalculator();
            var testResult = calculator.Calculate(valueOne, valueTwo);


            Assert.AreEqual(result, testResult);
        }
    }
}