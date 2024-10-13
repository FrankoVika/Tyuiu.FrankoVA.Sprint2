using Tyuiu.FrankoVA.Sprint2.Task5.V14.Lib;
namespace Tyuiu.FrankoVA.Sprint2.Task5.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2| Выполнила: Франко В.А. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Тернарный оператор                                                *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнила: Франко В.А. | ИБКСб-24-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет        *");
            Console.WriteLine("* требуемое значение и возвращает результат.                              *");
            Console.WriteLine("* Условие: Дано целое число k (1 <= k <= 365). Определить, каким днем     *");
            Console.WriteLine("* недели (понедельником, вторником, …, субботой или воскресеньем)         *");
            Console.WriteLine("* является k-й день не високосного года, в котором 1 января d-й день      *");
            Console.WriteLine("* недели (если 1 января — понедельник, то d = 1 , если вторник — d = 2    *");
            Console.WriteLine("*  , …, если воскресенье — d = 7).                                        *");
            Console.WriteLine("***************************************************************************");



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            Console.WriteLine(" Введите значение K: ");
            int k = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(" Введите значение D: ");
            int d = Convert.ToInt16(Console.ReadLine());
            string res = ds.FindDayName(k,d);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
