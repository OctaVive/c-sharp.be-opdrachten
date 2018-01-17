using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receipt_C_sharp_version
{
    class Program
    {
        static void Main(string[] args)
        {

            // Background color of console
            
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            string Name; // Input

            Console.WriteLine("Please enter your name: ");
            Name = Console.ReadLine();
            Console.Write(Name);
            Console.Clear();

           

            Console.WriteLine("Make your choice: ");
            Console.WriteLine("1. Pizza");
            Console.WriteLine("2. Spaghetti");
            Console.WriteLine("3. Salad");
            string str = Console.ReadLine();

            
            Double Pizza, Spaghetti, Salad, cost;

            

            // Prices
            Pizza = 9.00;
            Spaghetti = 8.50;
            Salad = 4.50;
            



            Double foodprice;

            switch (str)
            {
                case 1:
                case 
                    break;

                case 2:
                    foodprice = Spaghetti;
                    break;

                case 3:
                    foodprice = Salad;
                    break;


            }


            Console.Write(foodprice + "Hello");



                

                 
                

           

            

            
                   


                
           


     
     


        }
    }
}
