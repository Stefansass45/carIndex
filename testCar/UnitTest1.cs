using carIndex;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace testCar
{
    [TestClass]
    public class UnitTest1
    { 
        [TestMethod]
        public void enginecap()
        {
            Cars car = new Cars("2.0", "VW", "2007", 108000, 200000);
            Assert.AreEqual(car[0], 200000);
        }
        [TestMethod]
        public void model()
        {
            Cars car = new Cars("2.0", "VW", "2007", 108000, 200000);
            Assert.AreEqual(car[1], "VW");
        }
        [TestMethod]
        public void year()
        {
            Cars car = new Cars("2.0", "VW", "2007", 108000, 200000);
            Assert.AreEqual(car[2], "2007");
        }
        [TestMethod]
        public void milage()
        {
            Cars car = new Cars("2.0", "VW", "2007", 108000, 200000);
            Assert.AreEqual(car[3], 108000);
        }
        [TestMethod]
        public void price()
        {
            Cars car = new Cars("2.0", "VW", "2007", 108000, 200000);
            Assert.AreEqual(car[4], 200000);
        }
    }
}
