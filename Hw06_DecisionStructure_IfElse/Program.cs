using System;

namespace Hw06_DecisionStructure_IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = DateTime.Now.Hour;
            if(hour>=8 && hour<=11)
                Console.WriteLine("Gunaydin");
            else if (hour <= 18)
                Console.WriteLine("Iyi gunler");
            else
                Console.WriteLine("Iyi aksamlar");

            //Ternary If kullanimi
            string result = hour >= 8 && hour <= 11 ? "Gunaydin" : "Iyi aksamlar";
            Console.WriteLine(result);
        }
    }
}
