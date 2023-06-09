using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("podaj a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("podaj b");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a > b) { Console.WriteLine(a); }
            else { Console.WriteLine(b); }

        }
    }
}