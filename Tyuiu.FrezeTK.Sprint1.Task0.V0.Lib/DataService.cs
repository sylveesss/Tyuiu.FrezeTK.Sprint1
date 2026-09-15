using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.FrezeTK.Sprint1.Task0.V0.Lib
{
    public class DataService
    {
        public static double CalculateExpression()
        {
            // Используем тип double, чтобы деление выполнялось корректно
            double result = 4.0 / 2.0 * 5.0 / (3.0 + 2.0) * 5.0;
            return result;
        }
    }
}