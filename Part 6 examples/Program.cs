using System;

namespace Part_6_examples
{
    class Program
    {
        static void Main(string[] args)
        {
            int selection;
            do
            {
                Console.WriteLine("Who is the better captain?");
                Console.WriteLine("1 - Captain Picard");
                Console.WriteLine("2 - Captain Kirk");
                selection = Convert.ToInt32(Console.ReadLine());
            } while (selection != 1);
            Console.WriteLine("Correct");
        }
        }
    }

