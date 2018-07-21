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
        }
    }
}
