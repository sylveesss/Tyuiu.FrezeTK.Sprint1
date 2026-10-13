using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.FrezeTK.Sprint1.Task2.V1.Lib
{
    public class DataService : ISprint1Task2V1
    {
        // Поменяли имя метода на то, которое требует интерфейс
        public double ConvertKmToM(int value)
        {
            return Math.Round(value / 1.609, 3);
        }
    }
}
