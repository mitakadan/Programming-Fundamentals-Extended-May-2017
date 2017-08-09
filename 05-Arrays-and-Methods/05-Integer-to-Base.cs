using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Integer_to_Base
{
    class Program
    {
        static string IntegerToBase(int number, int toBase)
        {
            string result = string.Empty;
            while (number != 0)
            {
                int remainder = number % toBase;
                number /= toBase;
                result = remainder + result;
            }

            return result;

        }

        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int toBase = int.Parse(Console.ReadLine());

            Console.WriteLine(IntegerToBase(number, toBase));
        }
    }
}
