using calc.Sortes;
using NUnit.Framework;

namespace calc.Tests.ArraySortesTests
{
    [TestFixture]
    public class GnomeSortTest : AbstractSortTest
    {
        [SetUp]
        public void Initialize()
        {
            Sorter = new GnomeSort();
        }
    }
}