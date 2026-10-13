using System;
using Tyuiu.FrezeTK.Sprint1.Task5.V7.Lib;

namespace Tyuiu.FrezeTK.Sprint1.Task5.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Фрезе Т. К. | ИБКСб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Фрезе Татьяна Константиновна | ИБКСб-26-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Определить h – полное количество часов, прошедших от начала суток       *");
            Console.WriteLine("* до того момента, когда часовая стрелка повернулась на f градусов.       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите угол поворота часовой стрелки (f): ");
            double f = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            int h = ds.AngleToHoursMinutes(f);

            Console.WriteLine("Полное количество прошедших часов (h): " + h);
            Console.ReadKey();
        }
    }
}
