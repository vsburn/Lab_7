using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_2
{
    class Program
    {
        #region Задача 2
        // Создать метод для вычисления объема и площади поверхности куба по длине его ребра.
        #endregion
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра куба:");
            double a = Convert.ToDouble(Console.ReadLine());
            CalcCubeParam(a);
            Console.ReadKey();
        }
        static void CalcCubeParam(double a)
        {
            Console.WriteLine("Объём куба: {0} куб. ед", Math.Pow(a, 3));
            Console.WriteLine("Площадь поверхности куба: {0} кв. ед", 6 * a * a);
        }
    }
}
