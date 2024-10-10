using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.FrankoVA.Sprint2.Task2.V30.Lib
{
    public class DataService : ISprint2Task2V30
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if (x >= 3 && x <= 5 && y >= 3 && y <= 7) return true;
            else if (x >= 2 && x <= 2 && y >= 4 && y <= 6) return true;
            else if (x >= 9 && x <= 12 && y >= 3 && y <= 4) return true;
            else if (x >= 6 && x <= 12 && y >= 5 && y <= 7) return true;
            else if (x >= 13 && x <= 13 && y >= 6 && y <= 7) return true;
            else if (x >= 6 && x <= 6 && y >= 8 && y <= 10) return true;
            else if (x >= 3 && x <= 12 && y >= 11 && y <= 11) return true;
            else if (x >= 7 && x <= 10 && y >= 12 && y <= 12) return true;
            
            else return false;
        }
    }
}
