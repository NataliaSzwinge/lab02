using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("wpisz: a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("wpisz: b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("wpisz: c");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("wpisz: d");
            int d = Convert.ToInt32(Console.ReadLine());
            float u1 = ((a*d) / (b*d)) + ((c*b) / (d*b));
            Console.WriteLine("Wynik: " +  u1);
        }
    }
}