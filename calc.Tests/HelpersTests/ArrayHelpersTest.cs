using System;
using System.Linq;
using NUnit.Framework;

namespace calc.Helpers
{
    [TestFixture]
    public  class ArrayHelpersTest
    {
        [TestCase("1 2 3 4 5", ' ', new double[] { 1, 2, 3, 4, 5 })]
        [TestCase("-5", ' ', new double[] { -5 })]

        public void StringToArrayTest(string toSplit,char delimiter, double[] result)
        {

            var testResult = ArrayHelpers.StringToArray(toSplit, delimiter);
            Assert.AreEqual(result, testResult);
        }

        [TestCase(new double[] {1, 2, 3, 4, 5}, ',', "1,2,3,4,5")]
        [TestCase(new double[] { -5 }, ' ', "-5")]
        public void ArrayToStringTest(double[] array, char delimiter, string result)
        {
            var testResult = ArrayHelpers.ArrayToString(array, delimiter);
            Assert.AreEqual(result, testResult);

        }

        [Test]
        [ExpectedException(typeof(Exception))]
        public void EmptyStringToArrayTest()
        {
            ArrayHelpers.StringToArray("", ',');
        }

        [Test]
        [ExpectedException(typeof(Exception))]
        public void EmptyArrayToStringTest()
        {
            ArrayHelpers.ArrayToString(new double[]{}, ',');
        }

        [Test]
        [ExpectedException(typeof(Exception))]
        public void CrushedStringToArrayTest()
        {
            ArrayHelpers.StringToArray("1,,,,4", ',');
        }

    }
}