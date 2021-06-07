using System;

namespace Hw25_Enum
{
    static class Program
    {
        static void Main(string[] args)
        {
            // Enum, short for "enumerated"
            Console.WriteLine(Days.Wednesday);          // Wednesday -> bu string ifade degil sadece temsili bir ifade
            Console.WriteLine((int)Days.Wednesday);     // 2
            Console.WriteLine((int)Days.Monday);        // 0
            Console.WriteLine((int)Days.Tuesday);       // 1
            Console.WriteLine((int)Days.Saturday);      // 18
            Console.WriteLine((int)Days.Sunday);        // 19

            int temperature = 22;
            if (temperature <= (int)Weather.cold)
                Console.WriteLine("Hava cok soguk");
            else if (temperature > (int)Weather.cold && temperature <= (int)Weather.normal)
                Console.WriteLine("Sicaklik fena degil");
            else if (temperature > (int)Weather.normal && temperature <= (int)Weather.hot)
                Console.WriteLine("Hava guzel");
            else
                Console.WriteLine("Dikkat et! Hava cok sicak");

            



        }
    }

    enum Days   // Enum ifadelerinin uyeleri ifadeleri anlamlı hale getirir. Monday denen kisim aslinda 0 degerini(kendimiz sayi atamaz isek) tutar.
    {
        Monday = 0,
        Tuesday,
        Wednesday,
        Thursday = 4,
        Friday,
        Saturday = 18,
        Sunday
    }

    enum Weather
    {
        cold = 5,
        normal = 20,
        hot = 30
    }

}
