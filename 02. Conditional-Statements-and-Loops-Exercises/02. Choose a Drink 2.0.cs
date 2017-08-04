using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CS_and_L_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var prof = Console.ReadLine();
            var drinks = int.Parse(Console.ReadLine());

            switch (prof)
            {
                case "Athlete": Console.WriteLine($"The Athlete has to pay {(drinks * 0.70):F2}."); break;
                case "Businessman": Console.WriteLine($"The Businessman has to pay {drinks:F2}."); break;
                case "Businesswoman": Console.WriteLine($"The Businesswoman has to pay {drinks:F2}."); break;
                case "SoftUni Student": Console.WriteLine($"The SoftUni Student has to pay {(drinks*1.7):F2}."); break;
                default: Console.WriteLine($"The {prof} has to pay {(drinks*1.2):F2}."); break;
            }

        }
    }
}
