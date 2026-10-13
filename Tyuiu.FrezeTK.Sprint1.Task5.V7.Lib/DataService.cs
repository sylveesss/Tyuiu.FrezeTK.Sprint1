using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.FrezeTK.Sprint1.Task5.V7.Lib
{
    public class DataService : ISprint1Task5V7
    {
        // Метод называется строго AngleToHoursMinutes, как требует интерфейс
        public int AngleToHoursMinutes(double f)
        {
            // Делим угол на 30 градусов и отсекаем дробную часть, получая полные часы
            return (int)(f / 30.0);
        }
    }
}
