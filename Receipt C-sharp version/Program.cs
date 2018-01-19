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

           // Choices of food

            Console.WriteLine("Make your choice: ");
            Console.WriteLine("1. Pizza");
            Console.WriteLine("2. Spaghetti");
            Console.WriteLine("3. Salad");
            int choice = Convert.ToInt16(Console.ReadLine());

            // Prices of food

            Double Pizza = 9.01;
            Double Spaghetti = 8.51;
            Double Salad = 4.51;

            // Menu

            Double foodprice;
            string print_food;

            switch (choice)
            {
                case 1:
                    foodprice = Pizza;
                    print_food = "Pizza";
                    break;

                case 2:
                    foodprice = Spaghetti;
                    print_food = "Spaghetti";
                    break;

                case 3:
                    foodprice = Salad;
                    print_food = "Salad";
                    break;

                default:
                    throw new Exception("Invalid Choice"); 
             



            }

            Console.Clear();

            // Choices of drinks

            Console.WriteLine("What drink would you like?");
            Console.WriteLine("1. Beer");
            Console.WriteLine("2. Coke");
            Console.WriteLine("3. Ice Tea");
            int choice2 = Convert.ToInt16(Console.ReadLine());

            // Prices of drinks

            Double Beer = 3.01;
            Double Coke = 1.81;
            Double IceTea = 1.61;

            // Menu

            Double drinkprice;
            string print_drink;
            

            switch(choice2)
            {
                case 1:
                    drinkprice = Beer;
                    print_drink = "Beer";
                    break;

                case 2:
                    drinkprice = Coke;
                    print_drink = "Coke";
                    break;

                case 3:
                    drinkprice = IceTea;
                    print_drink = "Ice Tea";
                    break;

                default:
                    throw new Exception ("Invalid Choice");
            }

            Console.Clear();

            // Calculations

            Double tax = 0.09;
            Double total;
            Double tax_percent = tax + 1;

            total = (foodprice * tax_percent) + (drinkprice * tax_percent);

            var roundfood = Math.Round(foodprice, 2);
            var rounddrink = Math.Round(drinkprice, 2);
            var totalprice = Math.Round(total, 2);

            // Printing all stuff out

            Console.WriteLine("DATE = " + DateTime.Now);
            Console.WriteLine("NAME = " + Name);
            Console.WriteLine("FOOD (ex VAT) = " + print_food + " " + "$" + roundfood);
            Console.WriteLine("DRINK (ex VAT) = " + print_drink + " " + "$" + rounddrink);
            Console.WriteLine("TAX = " + tax + "%");
            Console.WriteLine("PRICE = " + "$" + totalprice);
            Console.Read();



     


        }
    }
}
