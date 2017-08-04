using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Digits_with_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            string charecter = "";
            for (int i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());
                charecter = charecter + Convert.ToChar(number);
            }
            Console.WriteLine(charecter);
        }
    }
}
