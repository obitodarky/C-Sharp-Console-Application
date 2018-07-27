using System;

namespace CommandLineCSharp
{
    class Program
    {
        public static void Main(String[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Console Application , press enter");
            Console.ReadLine();
            Console.WriteLine(Convert.ToString(32));
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("First Number");
            try
            {
                int x = Convert.ToInt32(Console.ReadLine());
                if (x > 2)
                {
                    Console.WriteLine((x) + " + 2 is " + (x + 2));
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
            catch (Exception)
            {
                Console.WriteLine("Please enter proper number");
            }

        }
    }
}
