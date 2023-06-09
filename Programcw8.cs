using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("podaj liczbe 1");
            int l1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("podaj liczbe 2");
            int l2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("numer dzialania");
            int nr = Convert.ToInt32(Console.ReadLine());

            if (nr == 1) { int dodawanie1 = l1 + l2;
                Console.WriteLine(dodawanie1);
            }
            if (nr == 2) { int odejmowanie2 = l1 - l2;
                Console.WriteLine(odejmowanie2);
            }
            if (nr == 3) { int mnozenie3 = l1 * l2;
                Console.WriteLine(mnozenie3);
            }
            if (nr == 4 && l2 !=0) { int dzielenie4 = l1 / l2;
                Console.WriteLine(dzielenie4);
            }
            else if (l2 == 0) { Console.WriteLine(l1 + "/0"); }

            

        }
    }
}