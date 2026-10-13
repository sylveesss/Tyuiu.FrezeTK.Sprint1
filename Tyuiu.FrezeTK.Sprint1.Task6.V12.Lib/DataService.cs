using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.FrezeTK.Sprint1.Task6.V12.Lib
{
    public class DataService : ISprint1Task6V12
    {
        // Убрали букву 'i' из Repetit[i]on по требованию интерфейса
        public bool CheckLastWordRepetiton(string value)
        {
            if (string.IsNullOrEmpty(value)) return false;

            string[] words = value.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (words.Length == 0) return false;

            string lastWord = words[words.Length - 1];

            return value.IndexOf(lastWord) != value.LastIndexOf(lastWord);
        }
    }
}
