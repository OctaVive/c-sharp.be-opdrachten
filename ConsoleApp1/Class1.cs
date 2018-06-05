using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class1
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            Double Number1, Number2, Sum;
          

            Console.Write("Give Number1: ");
            Number1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Give Number2: ");
            Number2 = Convert.ToDouble(Console.ReadLine());

            Sum = Number1 + Number2;
            Math.Round(Sum, 2);

            Console.WriteLine("De sum is " + Sum.ToString());
            Console.ReadLine();
            Console.WriteLine("Hi");
            Console.Read();

        }
    }
}
