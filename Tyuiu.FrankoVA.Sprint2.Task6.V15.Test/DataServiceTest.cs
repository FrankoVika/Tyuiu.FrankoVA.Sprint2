using Tyuiu.FrankoVA.Sprint2.Task6.V15.Lib;
namespace Tyuiu.FrankoVA.Sprint2.Task6.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int k = 6;
            
            string res = ds.FindDayName(k);
            string wait = "Суббота";
            Assert.AreEqual(wait, res);
        }
    }
}