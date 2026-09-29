using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.FrezeTK.Sprint1.Task2.V1.Lib
{
    public class DataService
    {
        public static double ConvertKmToMiles(int kilometers)
        {
            double miles = kilometers / 1.609;

            return Math.Round(miles, 3);
        }
    }
}