using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Nth_Digit
{
    class Program
    {
        static long FindNthDigit(long number, int index)
        {
            int indexCount = 1;
            long digitValue = 0;

            while (indexCount <= index)
            {
                digitValue = number % 10;
                if (indexCount == index)
                {
                    break;
                }
                number /= 10;
                indexCount++;
            }
            return digitValue;
        }

        static void Main(string[] args)
        {
            long number = int.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());

            Console.WriteLine(FindNthDigit(number, index));
        }
    }
}
