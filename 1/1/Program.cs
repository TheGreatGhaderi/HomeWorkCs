using System;

namespace ConsoleApp9
{

    class program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Mosalas(x, y, z));
            if (x + y > z && x + z > y && y + z > x) { Mosalas(x, y, z); }
            else { Console.WriteLine("Adade Varded Shode Mosalas Tashkil Nemidehand"); }

        }

        private static int Mosalas(int x, int y, int z)
        {

            int mosalas = x + y + z;
            return mosalas;

        }
    }
}