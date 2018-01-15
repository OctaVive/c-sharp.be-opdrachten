using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Background colors
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            // Ints
            Double EUR;
            Double USD;
            Double COURSE;

            // Input amount of EUR
            Console.Write("Give amount of EUR to convert: ");
            EUR = Convert.ToDouble(Console.ReadLine());

            // Calculation of USD
            COURSE = 1.2231;
            USD = EUR * COURSE;

            // Round up numbers

            var RoundedCOURSE = Math.Round(COURSE, 2);
            var RoundedEUR = Math.Round(EUR, 2);
            var RoundedUSD = Math.Round(USD, 2);

            // Give answer
            Console.WriteLine(RoundedEUR + " EUR is equal to " + RoundedUSD + " USD");
            Console.ReadLine();
            Console.WriteLine("Please press any key to continue");
            Console.Write(DateTime.Now);
            Console.ReadLine();
           

        }
    }
}
