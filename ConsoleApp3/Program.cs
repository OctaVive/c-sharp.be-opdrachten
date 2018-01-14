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
            EUR = Convert.ToInt16(Console.ReadLine());

            // Calculation of USD
            COURSE = 1.2231;
            USD = EUR * COURSE;

            // Give answer
            Console.WriteLine(EUR.ToString("n2") + " EUR is equal to " + USD.ToString("n2") + " USD");
            Console.ReadLine();

        }
    }
}
