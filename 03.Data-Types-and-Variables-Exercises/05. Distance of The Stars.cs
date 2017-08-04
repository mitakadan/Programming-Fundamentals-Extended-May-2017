using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Distance_of_The_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal oneLightYear = 9450000000000m;
            decimal distance1 = 4.22m * oneLightYear;
            decimal distance2 = 26000m * oneLightYear;
            decimal distance3 = 100000m * oneLightYear;
            decimal distance4 = 46500000000m * oneLightYear;

            Console.WriteLine($"{distance1:e2}");
            Console.WriteLine($"{distance2:e2}");
            Console.WriteLine($"{distance3:e2}");
            Console.WriteLine($"{distance4:e2}");
            ;        }
    }
}
