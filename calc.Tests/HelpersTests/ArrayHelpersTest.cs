using System;
using System.Linq;
using NUnit.Framework;

namespace calc.Helpers
{
    [TestFixture]
    public  class ArrayHelpersTest
    {
        [TestCase("1 2 3 4 5", ' ', new int[] { 1, 2, 3, 4, 5 })]
        [TestCase("-5", ' ', new int[] { -5 })]

        public void StringToArrayTest(string toSplit,char delimiter, int[] result)
        {

            var testResult = ArrayHelpers.StringToArray(toSplit, delimiter);
            Assert.AreEqual(testResult, result);
        }

        [TestCase(new int[] {1, 2, 3, 4, 5}, ',', "1,2,3,4,5")]
        [TestCase(new int[] { -5 }, ' ', "-5")]
        public void ArrayToStringTest(int[] array, char delimiter, string result)
        {
            var testResult = ArrayHelpers.ArrayToString(array, delimiter);
            Assert.AreEqual(testResult, result);

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
            ArrayHelpers.ArrayToString(new int[]{}, ',');
        }

        [Test]
        [ExpectedException(typeof(Exception))]
        public void CrushedStringToArrayTest()
        {
            ArrayHelpers.StringToArray("1,,,,4", ',');
        }

    }
}