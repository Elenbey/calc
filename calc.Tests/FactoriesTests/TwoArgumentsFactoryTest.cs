using System;
using calc.SingleArgumentCalcs;
using calc.TwoArgumentsCalculator;
using NUnit.Framework;

namespace calc.Factories
{
    [TestFixture]
    public class TwoArgumentsFactoryTest
    {
        [TestCase("Addition", typeof(AdditionCalculator))]
        [TestCase("Division", typeof(DivisionCalculator))]
        [TestCase("Multiply", typeof(MultiplyCalculator))]
        [TestCase("Power", typeof(PowerCalculator))]
        [TestCase("Subtraction", typeof(SubtractionCalculator))]
       
        public void CreateCalculatorTest(string calculatorName, Type expectedCalculator)
        {
            var calculator = TwoArgumentsFactory.CreateCalculator(calculatorName);

            Assert.AreEqual(calculator.GetType(), expectedCalculator);

        }

        [Test]
        [ExpectedException(typeof(Exception))]
        public void UnknownCalculatorTest()
        {
            var calculator = TwoArgumentsFactory.CreateCalculator("wrong name");
        }
    }
}