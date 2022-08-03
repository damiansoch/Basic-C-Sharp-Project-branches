using System;

namespace Basic_C_Sharp_Project_branches
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("What is the weight of the package?");
            double weight = Convert.ToInt32(Console.ReadLine());

            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("What is the width of the package?");
                int width = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What is the height of the package?");
                int height = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What is the lenght of the package?");
                int lenght = Convert.ToInt32(Console.ReadLine());

                if (width + height + lenght > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.ReadLine();
                }
                else
                {
                    double priceQuote = ((width * height * lenght) * weight) / 100;
                    Console.WriteLine("The price for sending the package is: " + "\u00A3" + priceQuote);
                }

            }


        }
    }
}
