using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.FrezeTK.Sprint1.Task4.V24.Lib
{
    public class DataService : ISprint1Task4V24
    {
        public double Calculate(double x, double y)
        {
            // Исправленная формула: в знаменателе первым идет символ 'x', а не 'z'
            // Обязательно берем под корень только y^2, а двойка умножается ПЕРЕД корнем: 2 * sqrt(y^2)
            double numerator = Math.Log(x * y);
            double denominator = x + 2.0 * Math.Sqrt(Math.Pow(y, 2));

            // Вычисляем и округляем строго до 3 знаков
            return Math.Round(numerator / denominator, 3);
        }
    }
}
