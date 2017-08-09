using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Notifications
{
    class Program
    {
        static void ShowSuccess(string operation, string message)
        {
            Console.WriteLine($"Successfully executed {operation}.");
            Console.WriteLine("==============================");
            Console.WriteLine($"Message: {message}.");
        }

        static void ShowError(string operation, int code)
        {
            string reason = "";

            if (code > 0) reason = "Invalid Client Data";
            else reason = "Internal System Failure";

            Console.WriteLine($"Error: Failed to execute {operation}.");
            Console.WriteLine("==============================");
            Console.WriteLine($"Error Code: {code}.");
            Console.WriteLine($"Reason: {reason}.");
        }

        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                string result = Console.ReadLine();
                switch (result)
                {
                case "success":
                {
                    string operation = Console.ReadLine();
                    string message = Console.ReadLine();
                    ShowSuccess(operation, message);
                    break;
                }
                case "error":
                {
                    string operation = Console.ReadLine();
                    int code = int.Parse(Console.ReadLine());
                    ShowError(operation, code);
                    break;
                }
                }
            }
        }
    }
}
