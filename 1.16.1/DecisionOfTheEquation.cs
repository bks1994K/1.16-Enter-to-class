using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._16._1
{
    public static class DecisionOfTheEquation

    {
        public static int ReadFromConsole()
        {
            Console.WriteLine("Введите число");
            string s = Console.ReadLine();
            int number=Convert.ToInt32(s);
            return number;  
        }

        public static int MinusAndDivision(int a, int b, int c)
        {
            int result = (c - b) / a;
            return result;
        }

        public static void WriteResult(int result)
        {
            Console.WriteLine($"Решение уравнения {result}");
        }
    }
}
