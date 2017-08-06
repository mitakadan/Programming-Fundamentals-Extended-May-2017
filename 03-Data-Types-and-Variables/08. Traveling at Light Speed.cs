using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Traveling_at_Light_Speed
{
    class Program
    {
        static void Main(string[] args)
        {
            var lightYears = decimal.Parse(Console.ReadLine());
            decimal oneLightYear = 9450000000000m; // km
            decimal speedOfLight = 300000m; // km/second
            decimal totalSeconds = (lightYears * oneLightYear) / speedOfLight;
            var weeks = Math.Floor(totalSeconds / 604800);
            var days = Math.Floor((totalSeconds - weeks * 604800) / 86400);
            var hours = Math.Floor((totalSeconds - weeks * 604800 - days * 86400) / 3600);
            var minutes = Math.Floor((totalSeconds - weeks * 604800 - days * 86400 - hours * 3600) / 60);
            var seconds = Math.Floor(totalSeconds - weeks * 604800 - days * 86400 - hours * 3600 - minutes * 60);
            Console.WriteLine(weeks + " weeks"); 
            Console.WriteLine(days + " days");
            Console.WriteLine(hours + " hours");
            Console.WriteLine(minutes + " minutes");
            Console.WriteLine(seconds + " seconds");

        }
    }
}
