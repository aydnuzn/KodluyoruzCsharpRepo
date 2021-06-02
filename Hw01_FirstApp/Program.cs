using System;

namespace Hw01_FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Isminizi Giriniz : ");
            string name = Console.ReadLine().Trim();
            Console.Write("Soyadinizi Giriniz : ");
            string surname = Console.ReadLine().Trim();

            Console.WriteLine($"Merhaba {name} {surname}");
            
        }
    }
}
