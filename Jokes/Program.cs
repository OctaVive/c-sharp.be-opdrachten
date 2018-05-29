using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jokes
{
    
    class Program
    {
        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            string Name;

            Console.WriteLine("What is your name? ");
            Name = Console.ReadLine();
            Console.Write(Name);
            Console.Clear();

            Console.WriteLine("What is your age?");
            int Age = Convert.ToInt16(Console.ReadLine());
            Console.Write(Age);
            Console.Clear();

           


            string[] jokes = new string[] { "Joke1", "Joke2", "Joke3", "Joke4" };
            int upper = jokes.GetUpperBound(0);
            int lower = jokes.GetLowerBound(0);

         
            Random rnd = new Random();
            int jk = rnd.Next(lower, upper + 1);
            
            
            

            if (Age >= 16)
            {
                Console.WriteLine("Do you want to hear a joke?");

                string option = Console.ReadLine();

                if (option == "yes")
                {
                    Console.WriteLine(jokes[jk]);
                    Console.Read();

                    Console.WriteLine("Do you want to hear another joke?");
                    string option2 = Console.ReadLine();

                    int i;

                    if (option2 == "yes")
                    {
                        i = 0;
                    }
                    


                    else
                    {
                        i = 1;
                    }

                    do
                    {
                        Console.WriteLine(jokes[jk]);
                        Console.Read();
                    } while (i == 0);

                }

                else
                {
                    Console.WriteLine("Have a nice day, " + Name);
                    Console.Read();
                }

            }
            else
            {
                Console.WriteLine("What a pitty! You're too young to hear this joke!");
                Console.Read();
                Console.WriteLine("Have a nice day, " + Age);
            }
        }
    }
}

