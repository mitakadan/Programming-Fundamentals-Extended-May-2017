using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Arrays_and_Methods
{
    class Program
    {
        private static void Hello(string x)
        {
            Console.WriteLine($"Hello, {x}!");
        }
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Hello(name);
        }
    }
}
