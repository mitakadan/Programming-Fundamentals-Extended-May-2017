using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.From_Terabytes_to_Bits
{
    class Program
    {
        static void Main(string[] args)
        {

            var terabytes = decimal.Parse(Console.ReadLine());
            Console.WriteLine(Math.Round(terabytes * 1024 * 1024 * 1024 * 1024 * 8));

        }
    }
}
