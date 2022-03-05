using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestLibrary;

namespace Tests
{
    [TestClass]
    public class SimplUnitTest
    {
        [TestMethod]
        public void SumClassTest()
        {
            Assert.AreEqual(SumClass.Sum(1.0, 2.0), 3.0);
        }
    }
}