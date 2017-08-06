using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Tricky_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var delimiter = Console.ReadLine();
            var N = int.Parse(Console.ReadLine());
            string result = "";
            for (int i = 0; i < N; i++)
            {
                var input = Console.ReadLine();
                if (i == 0) result += input;
                else result += delimiter + input;
            }
            Console.WriteLine(result);
        }
    }
}
