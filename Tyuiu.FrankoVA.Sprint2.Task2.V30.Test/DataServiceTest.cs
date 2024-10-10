using Tyuiu.FrankoVA.Sprint2.Task2.V30.Lib;
namespace Tyuiu.FrankoVA.Sprint2.Task2.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 6;
            int y = 8;


            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}