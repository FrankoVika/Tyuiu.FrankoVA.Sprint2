using Tyuiu.FrankoVA.Sprint2.Task7.V4.Lib;
namespace Tyuiu.FrankoVA.Sprint2.Task7.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = -0.2;
            double y = 1;
            bool res = ds.CheckDotInShadedArea(x,y);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}