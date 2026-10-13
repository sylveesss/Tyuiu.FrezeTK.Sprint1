using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.FrezeTK.Sprint1.Task7.V9.Lib
{
    public class DataService : ISprint1Task7V9
    {
        public double Calculate(double x, double y)
        {
            double numerator = Math.Pow(y, 2) + Math.Cos(Math.Pow(x, 3)) + 12.0 * x * y - 3.0 * Math.Pow(x, 2);
            double denominator = Math.Cos(Math.Pow(x, 3) + 3.0) + 18.0 * y - 1.0;
            double z = Math.Exp(x) - (numerator / denominator);

            return Math.Round(z, 3);
        }
    }
}
