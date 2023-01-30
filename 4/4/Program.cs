using System;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            int d;
            d = Convert.ToInt32(Console.ReadLine());
            Age(d);

        }
        private static void Age(int d)
        {
            int y, m, w;
            y = d / 365;
            d %= 365;
            m = d / 30;
            d %= 30;
            w = d / 7;
            d %= 7;
            Console.WriteLine(y);
            Console.WriteLine(m);
            Console.WriteLine(w);
            Console.WriteLine(d);
        }




    }
}