using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Background colors
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            int Celsius;
            
            // Get the numbers

            Console.Write("Amount of Celsius: ");
            Celsius = Convert.ToInt16(Console.ReadLine());

            // Calculate

            Double Total = 9.0 / 5.0;
            Double FirstSum = Total * Celsius + 32; 
         
   
            // Show result

            Console.WriteLine(Celsius + " degrees Celsius is equal to " + FirstSum + " Fahrenheit");
            Console.ReadLine();

        }
    }
}


