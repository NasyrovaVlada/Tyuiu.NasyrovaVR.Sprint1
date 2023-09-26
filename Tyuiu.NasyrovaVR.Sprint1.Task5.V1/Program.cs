using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.NasyrovaVR.Sprint1.Task5.V1.Lib;

namespace Tyuiu.NasyrovaVR.Sprint1.Task5.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт #1 | Выполнила: Насырова В. Р. | ИИПб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Преобразование типов и класс Convert                              *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнила: Насырова Влада Ренатовна | ИИПб-23-3                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет расстояние между двумя точками с  *");
            Console.WriteLine("* заданными координатами (x, y). Ответ - целое число.                     *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение X1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Y1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение X2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Y2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = Convert.ToInt32(ds.DistanceBetweenDots(x1, y1, x2, y2));
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
