using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_1
{
    class Program
    {
        #region Задача 1
        /* Два треугольника заданы длинами своих сторон.
         * Определить, площадь какого из них больше (создать метод для вычисления  площади  треугольника по длинам его сторон).  
         * Для решения задачи можно использовать формулу Герона 
         */
        #endregion
        static void Main(string[] args)
        {
            double a, b, c, x, y, z;
            do
            {
                Console.WriteLine("Введите стороны первого треугольника:");
                a = Convert.ToDouble(Console.ReadLine());
                b = Convert.ToDouble(Console.ReadLine());
                c = Convert.ToDouble(Console.ReadLine());
            } while (!CheckTriangle(a, b, c)); 
            do
            {
                Console.WriteLine("Введите стороны второго треугольника:");
                x = Convert.ToDouble(Console.ReadLine());
                y = Convert.ToDouble(Console.ReadLine());
                z = Convert.ToDouble(Console.ReadLine());
            } while (!CheckTriangle(x, y, z));
            if (CalculationArea(a, b, c) == CalculationArea(x, y, z))
            {
                Console.WriteLine("Площади треугольников равны");
            }
            else
            {
                Console.WriteLine((CalculationArea(a, b, c) > CalculationArea(x, y, z)) ? "Площадь первого треугольника больше" : "Площадь второго треугольника больше");
            }
            Console.ReadKey();
        }
        static bool CheckTriangle(double a, double b, double c)
        {
            return ((a + b) > c) && ((a + c) > b) && ((b + c) > a);
        }
        static double CalculationArea(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
