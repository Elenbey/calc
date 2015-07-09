using calc.Sortes;
using NUnit.Framework;

namespace calc.Tests.ArraySortesTests
{
    [TestFixture]
    public class SelectionSortTest : AbstractSortTest
    {
        [SetUp]
        public void Initialize()
        {
            Sorter = new SelectionSort();
        }
    }
}