using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.FrezeTK.Sprint1.Task1.V10.Lib
{
    public class DataService
    {
        public static double Calculate(double x, double y)
        {
            // Реализация формулы (x + y) / (1 + x)
            return (x + y) / (1 + x);
        }
    }
}