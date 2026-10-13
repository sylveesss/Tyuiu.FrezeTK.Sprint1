using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.FrezeTK.Sprint1.Task4.V24.Lib;

namespace Tyuiu.FrezeTK.Sprint1.Task4.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Фрезе Т. К. | ИБКСб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнил: Фрезе Татьяна Константиновна | ИБКСб-26-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* вычисляет результат по формуле ln(xy)/(x+sqrt(2y^2)) и печатает         *");
            Console.WriteLine("* его на экране. Ответ округлить до 3 знаков после запятой.               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            // Для работы натурального логарифма (ln) произведение x * y должно быть строго больше 0
            Console.Write("Введите значение X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            double result = ds.Calculate(x, y);

            Console.WriteLine("Результат вычисления равен: " + result);
            Console.ReadKey();
        }
    }
}
