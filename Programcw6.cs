using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("podaj bok a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("podaj bok b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("podaj bok c");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a == b && b == c && a == c) { Console.WriteLine("mozna utworzyc trojkat"); }
            else { Console.WriteLine("nie da sie stworzyc trojkta"); }
        }
    }
}