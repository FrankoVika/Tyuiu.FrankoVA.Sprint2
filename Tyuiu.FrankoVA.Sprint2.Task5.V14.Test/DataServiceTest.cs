using Tyuiu.FrankoVA.Sprint2.Task5.V14.Lib;
namespace Tyuiu.FrankoVA.Sprint2.Task5.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int k = 10;
            int d = 5;
            string res = ds.FindDayName(k, d);
            string wait = "Воскресенье";
            Assert.AreEqual(wait, res);
        }
    }
}