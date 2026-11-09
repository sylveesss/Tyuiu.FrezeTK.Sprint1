using System;

namespace Tyuiu.FrezeTK.Sprint1.Task7.V9.Lib
{
    public class DataService
    {
        public static double Calculate(double x, double y)
        {
            double numerator = Math.Pow(y, 2) + Math.Cos(Math.Pow(x, 3)) + 12 * x * y - 3 * Math.Pow(x, 2);
            double denominator = Math.Cos(Math.Pow(x, 3) + 3) + 18 * y - 1;

            double z = Math.Exp(x) - (numerator / denominator);

            return Math.Round(z, 3);
        }
    }
}
