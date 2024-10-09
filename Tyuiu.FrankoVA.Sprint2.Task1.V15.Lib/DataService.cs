using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.FrankoVA.Sprint2.Task1.V15.Lib
{
    public class DataService : ISprint2Task1V15
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (a + 210 > b) | (c < d);
            res[1] = (a > b) & (c < d);
            res[2] = (a > b) || (c < d); 
            res[3] = (a + 210 > b) && (c < d);
            res[4] = !(!res[1]);
            res[5] = (a + 210 > b) ^ (c < d);
            return res;
        }
    }
}
//int a = 415;
//int b = 616;
//int c = 134;
//int d = 127;