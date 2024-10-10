using Tyuiu.FrankoVA.Sprint2.Task2.V30.Lib;
namespace Tyuiu.FrankoVA.Sprint2.Task2.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2| Выполнила: Франко В.А. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор if – полная и короткая форма записи                      *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнила: Франко В.А. | ИБКСб-24-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу на, которая запрашивает целые значения с клавиатуры  *");
            Console.WriteLine("* и вычисляет находится ли точка с координатами X,Y в заштрихованной      *");
            Console.WriteLine("* области.                                                                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

           
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            
            DataService ds = new DataService();
            Console.WriteLine(" Введите значение X: ");
            int x = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine(" Введите значение Y: ");
            int y = Convert.ToInt32(Console.ReadLine()); 
            bool res = ds.CheckDotInShadedArea(x, y);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            if (res)
            {
                Console.WriteLine(" Точка находится в заштрихованной области ");
            }
            else
            {
                Console.WriteLine(" Точка не находится в заштрихованной области ");
            }
            Console.ReadKey();
        }
    }
}
