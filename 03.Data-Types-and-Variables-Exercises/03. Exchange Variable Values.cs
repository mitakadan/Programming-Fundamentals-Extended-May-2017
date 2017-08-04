using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Console.ReadLine();
            var b = Console.ReadLine();

            var c = a;
            a = b;
            b = c;

            Console.WriteLine(a);
            Console.WriteLine(b);


        }
    }
}
