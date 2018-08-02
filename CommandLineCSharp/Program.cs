using System;

namespace CommandLineCSharp
{
    class Program
    {
        public static void Main(String[] args)
        {
            
            //font color
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Console Application , Enter Name : ");

            /* Break Point */


            bool status = false;
            //font background color
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            //Console.WriteLine(" Hello {0}! " , Console.ReadLine());
            Console.WriteLine("Hello " + Console.ReadLine());
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
                        Console.WriteLine("Good" +  (y+x));
                        status = true;
                    }
                    else
                    {
                        Console.WriteLine("Bad");
                        Console.WriteLine("Please don't enter " + y);
                        status = false;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter proper number");
            }

            if (status == false)
            {

                Console.WriteLine("What did I tell you about entering a proper number you dumb shit ");
                Console.WriteLine("Press q to quit");
                String q = Convert.ToString(Console.Read());

                if(q == "q"){
                    Environment.Exit(0);
                }

            } else {
                Console.WriteLine("Good Work!");
                Console.WriteLine("Press q to quit");
                String q = Convert.ToString(Console.Read());

                if(q == "q"){
                    Environment.Exit(0);
                }
            }

        }
    }
}


