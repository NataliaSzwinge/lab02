using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double x, y, r, odlegloscOdSrodka;

        Console.WriteLine("podaj x");
        x = inputValue();
        Console.WriteLine("y");
        y = inputValue();
        Console.WriteLine("r");
        r = inputValue();
        if (x * x + y * y <= r * r)
        {
            Console.WriteLine("wspolrzedne sa w kole");
        }
        else
        {
            Console.WriteLine("wspolrzednie nie sa w kole");
        }
    }

    // .NET can only read single characters or entire lines from the
    // console. The following function safely reads a double value.
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}
