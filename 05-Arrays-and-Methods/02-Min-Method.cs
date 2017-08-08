using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Min_Method
{
    class Program
    {
        private static int GetMin(int x, int y)
        {
            if (x < y)
            {
                return x;
            }
            return y;
        }

        static void Main()
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
        

            int min = GetMin(number1, number2);
            int minPrint = GetMin(min, number3);

            Console.WriteLine(minPrint);

        }
    }
}
