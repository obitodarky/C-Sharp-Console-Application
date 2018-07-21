using System;

namespace CommandLineCSharps
{
    class MainClass
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("First Console Application");
            Console.ReadLine();

            Console.WriteLine("First Number");
            try
            {
                int x = Convert.ToInt32(Console.ReadLine());
                if (x > 2)
                {
                    Console.WriteLine("x + 2 is " + (x + 2));
                }
                else
                {
                    Console.WriteLine("Enter a number which is greater than 2");
                    int y = Convert.ToInt32(Console.ReadLine());
                    if (y > 2)
                    {
                        Console.WriteLine("Good");
                    }
                    else
                    {
                        Console.WriteLine("Bad");
                    }
                }
            }
            catch (Exception){
                Console.WriteLine("Please enter proper number");
            }

        }
    }
}
