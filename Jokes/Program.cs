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



            string[] jokes = new string[] { "you", "your life", "your future", "your face", "your existence" };
            int upper = jokes.GetUpperBound(0);
            int lower = jokes.GetLowerBound(0);


            bool keepTellingJokes = true;

            if (Age >= 16)
            {
                Console.WriteLine("Do you want to hear a joke?");

                string option = Console.ReadLine();

                if (option == "yes")
                {
                    while (keepTellingJokes)
                    {
                        Random rnd = new Random();
                        int jk = rnd.Next(lower, upper + 1);
                        Console.Clear();
                        Console.WriteLine(jokes[jk]);
                        Console.Read();

                        Console.Clear();
                        Console.WriteLine("Do you want to hear another joke?");
                        Console.Read();
                        string option2 = Console.ReadLine();

                        if (option2 == "no")
                        {
                            keepTellingJokes = false;
                            Console.Clear();
                            Console.WriteLine("Have a nice day, " + Name);
                            Console.Read();
                        }

                    }

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

