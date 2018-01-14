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

            int Number1, Number2, Sum;

            Console.Write("Give Number1: ");
            Number1 = Convert.ToInt16(Console.ReadLine());

            Console.Write("Give Number2: ");
            Number2 = Convert.ToInt16(Console.ReadLine());

            Sum = Number1 + Number2;

            Console.WriteLine("De sum is " + Sum.ToString());
            Console.ReadLine();

        }
    }
}
