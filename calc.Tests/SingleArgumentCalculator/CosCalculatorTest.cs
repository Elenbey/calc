using System;
using calc.SingleArgumentCalcs;
using NUnit.Framework;

namespace calc.Tests.SingleArgumentCalcs
{
    [TestFixture]
    public class CosCalculatorTest
    {
        [Test]
        public void CalculateTest()
        {
            var calculator = new CosCalculator();
            var testResult = calculator.Calculate(0);
            var realResult = Math.Cos(0);
            Assert.AreEqual(testResult, realResult);

        }
    }
}