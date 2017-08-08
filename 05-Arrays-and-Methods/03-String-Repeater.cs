using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_String_Repeater
{
    class Program
    {
        static string RepeatString(string str, int count)
        {
            string repeatedString = string.Empty;

            for (int i = 0; i < count; i++)
            {
                repeatedString += str;
            }

            return repeatedString;
        }

        static void Main(string[] args)
        {
            string stringToRepeat = Console.ReadLine();
            int numOfRepeats = int.Parse(Console.ReadLine());
            Console.WriteLine(RepeatString(stringToRepeat, numOfRepeats));
        }
    }
}
