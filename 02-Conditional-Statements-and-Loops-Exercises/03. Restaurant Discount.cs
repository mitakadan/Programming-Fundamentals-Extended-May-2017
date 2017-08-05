using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            var group = int.Parse(Console.ReadLine());
            var pack = Console.ReadLine();

            if (group <= 50)
            {
                Console.WriteLine("We can offer you the Small Hall");
                switch (pack)
                {
                    case "Normal":
                        {
                            var price = (3000 - (3000 * 0.05))/group;
                            Console.WriteLine($"The price per person is {price:F2}$");
                            break;
                        }
                    case "Gold":
                        {
                            var price = (3250 - (3250 * 0.1))/group;
                            Console.WriteLine($"The price per person is {price:F2}$");
                            break;
                        }
                    case "Platinum":
                        {
                            var price = (3500 - (3500 * 0.15)) / group;
                            Console.WriteLine($"The price per person is {price:F2}$");
                            break;
                        }
                }
            }
            if (group > 50 && group <= 100)
            {
                Console.WriteLine("We can offer you the Terrace");
                switch (pack)
                {
                    case "Normal":
                        {
                            var price = (5500 - (5500 * 0.05)) / group;
                            Console.WriteLine($"The price per person is {price:F2}$");
                            break;
                        }
                    case "Gold":
                        {
                            var price = (5750 - (5750 * 0.1)) / group;
                            Console.WriteLine($"The price per person is {price:F2}$");
                            break;
                        }
                    case "Platinum":
                        {
                            var price = (6000 - (6000 * 0.15)) / group;
                            Console.WriteLine($"The price per person is {price:F2}$");
                            break;
                        }
                }
            }
                if (group > 100 && group <= 120)
                {
                    Console.WriteLine("We can offer you the Great Hall");
                    switch (pack)
                    {
                        case "Normal":
                            {
                                var price = (8000 - (8000 * 0.05)) / group;
                                Console.WriteLine($"The price per person is {price:F2}$");
                                break;
                            }
                        case "Gold":
                            {
                                var price = (8250 - (8250 * 0.1)) / group;
                                Console.WriteLine($"The price per person is {price:F2}$");
                                break;
                            }
                        case "Platinum":
                            {
                                var price = (8500 - (8500 * 0.15)) / group;
                                Console.WriteLine($"The price per person is {price:F2}$");
                                break;
                            }
                    }
                }
                if (group > 120) Console.WriteLine("We do not have an appropriate hall.");

            
        }
    }
}
