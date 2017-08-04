using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var operand1 = int.Parse(Console.ReadLine());
            char operator1 = char.Parse(Console.ReadLine());
            var operand2 = int.Parse(Console.ReadLine());

            int result = 0;
            switch (operator1)
            {
                case '+': result = operand1 + operand2; break;
                case '-': result = operand1 - operand2; break;
                case '*': result = operand1 * operand2; break;
                case '/': result = operand1 / operand2; break;
                default: break;
            }
            Console.WriteLine($"{operand1} {operator1} {operand2} = {result}");
        }
    }
}
