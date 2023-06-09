using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj wzrost: ");
            int wzrost = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj wage: ");
            int waga = Convert.ToInt32(Console.ReadLine());
            
            int bmi = waga / (wzrost * wzrost);
            Console.WriteLine("BMI: " +  bmi);
        }
    }
}