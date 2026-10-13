using System;
using Tyuiu.FrezeTK.Sprint1.Task6.V12.Lib;

namespace Tyuiu.FrezeTK.Sprint1.Task6.V12
{
    class Program
    {
        static void Main(string args)
        {
            Console.Title = "Спринт #1 | Выполнил: Фрезе Т. К. | ИБКСб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Работа со строками (класс String)                                 *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Фрезе Татьяна Константиновна | ИБКСб-26-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Пользователь вводит текст. Проверить, что последнее слово строки        *");
            Console.WriteLine("* входит в нее еще раз.                                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите текст: ");
            string text = Console.ReadLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            bool result = ds.CheckLastWordRepetiton(text);

            if (result)
            {
                Console.WriteLine("Да, последнее слово входит в строку еще раз.");
            }
            else
            {
                Console.WriteLine("Нет, последнее слово встречается в строке только один раз.");
            }

            Console.ReadKey();
        }
    }
}
