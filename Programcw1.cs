using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbe a");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj liczbe b");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj liczbe c");
            int C = Convert.ToInt32(Console.ReadLine());
            int srednia = A + B + C / 3;
            Console.WriteLine("Srednia: " +  srednia);
        }
    }
}