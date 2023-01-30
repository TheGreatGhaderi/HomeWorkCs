using System;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Enter The Number: ");
            x = Convert.ToInt32(Console.ReadLine()); tavan(x);
        }
        static void tavan(int x)
        {
            Console.WriteLine(Math.Pow(x, 2)); Console.WriteLine(Math.Pow(x, 3));
        }
    }
}
