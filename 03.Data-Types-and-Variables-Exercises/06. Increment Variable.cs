using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Increment_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var overflowTimes = 0;
            byte result = 1;
            for (int i = 0; i < n; i++)
            {
                result++;
                if(result == 0)
                {
                    overflowTimes++;
                }
            }
            if (overflowTimes!=0)
            {
                Console.WriteLine(result-1);
                Console.WriteLine($"Overflowed {overflowTimes} times");
            }
            else Console.WriteLine(n);

        }
    }
}
