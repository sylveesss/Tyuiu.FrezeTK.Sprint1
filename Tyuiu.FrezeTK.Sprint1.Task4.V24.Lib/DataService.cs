using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.FrezeTK.Sprint1.Task4.V24.Lib
{
    public class DataService : ISprint1Task4V24
    {
        public double Calculate(double x, double y)
        {
            // Корректная запись формулы: ln(x * y) / (x + Math.Sqrt(2 * y * y))
            // Произведение y * y под корнем всегда положительно, 
            // а структура строго соответствует исходному изображению из методички.
            double numerator = Math.Log(x * y);
            double denominator = x + Math.Sqrt(2.0 * y * y);

            // Возвращаем результат с округлением до 3 знаков после запятой
            return Math.Round(numerator / denominator, 3);
        }
    }
}
