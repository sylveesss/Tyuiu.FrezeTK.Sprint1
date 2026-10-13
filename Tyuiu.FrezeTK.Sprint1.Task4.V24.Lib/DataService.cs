using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.FrezeTK.Sprint1.Task4.V24.Lib
{
    public class DataService : ISprint1Task4V24
    {
        public double Calculate(double x, double y)
        {
            // Формула задания: ln(x * y) / (x + sqrt(2 * y^2))
            double numerator = Math.Log(x * y);
            double denominator = x + Math.Sqrt(2.0 * Math.Pow(y, 2));

            // Вычисляем результат и округляем до 3 знаков после запятой
            return Math.Round(numerator / denominator, 3);
        }
    }
}
