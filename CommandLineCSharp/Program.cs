using System;

namespace CommandLineCSharp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("First Console Application");
            Console.ReadLine();

            Console.WriteLine("First Number");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(x + 2);

            if(x>2){
                Console.WriteLine("x is greater than 2");
            } else {
                Console.WriteLine("Enter a number which is greater than 2");
                int y = Convert.ToInt32(Console.ReadLine());
                if(y>2){
                    Console.WriteLine("Good");
                }else{
                    Console.WriteLine("Bad");
                }
            }
        }
    }
}
