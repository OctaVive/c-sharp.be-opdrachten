using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            string EUR;

            // Write name only.

            Console.Write("Write your name: ");
            EUR = Convert.ToString(Console.ReadLine());
            Console.WriteLine(EUR.ToString());
            Console.ReadLine();

            // Write a full sentence.

            Console.WriteLine("Your name is " + EUR.ToString());
            Console.ReadLine();



        }
    }
}
