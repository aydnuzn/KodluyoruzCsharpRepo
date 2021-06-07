using System;

namespace Hw16_DatetimeMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);
            Console.WriteLine(DateTime.Now.Millisecond);

            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine(DateTime.Now.AddDays(5));
            Console.WriteLine(DateTime.Now.AddHours(1));
            Console.WriteLine(DateTime.Now.AddSeconds(30));
            Console.WriteLine(DateTime.Now.AddMonths(2));
            Console.WriteLine(DateTime.Now.AddYears(3));
            Console.WriteLine(DateTime.Now.AddMilliseconds(83));

            // Datetime Format
            Console.WriteLine(DateTime.Now.ToString("dd")); //05
            Console.WriteLine(DateTime.Now.ToString("ddd")); //Cmt
            Console.WriteLine(DateTime.Now.ToString("dddd")); //Cumartesi

            Console.WriteLine(DateTime.Now.ToString("MM")); //06
            Console.WriteLine(DateTime.Now.ToString("MMM")); //Haz
            Console.WriteLine(DateTime.Now.ToString("MMMM")); //Haziran

            Console.WriteLine(DateTime.Now.ToString("yy")); //21
            Console.WriteLine(DateTime.Now.ToString("yyyy")); //2021

            // Math Library
            Console.WriteLine(Math.Abs(-13)); // 13
            Console.WriteLine(Math.Sin(10)); // -0,5440211108893698
            Console.WriteLine(Math.Cos(10)); // -0,8390715290764524

            Console.WriteLine(Math.Ceiling(4.2)); // 5
            Console.WriteLine(Math.Round(4.7));   // 5
            Console.WriteLine(Math.Round(4.5));   // 5
            Console.WriteLine(Math.Round(4.2));   // 4
            Console.WriteLine(Math.Floor(4.7));   // 4 

            Console.WriteLine(Math.Max(8,3));  // 8
            Console.WriteLine(Math.Min(5,12)); // 5

            Console.WriteLine(Math.Pow(3,4)); // 3^4 = 81
            Console.WriteLine(Math.Sqrt(9));  // square -> 3 
            Console.WriteLine(Math.Log(10)); // logarithm(e tabanindaki karsiligi) -> 2,302585092994046
            Console.WriteLine(Math.Log2(16)); // logarithm(2 tabanindaki karsiligi) -> 4
            Console.WriteLine(Math.Exp(3));  // e^3 = 20,085536923187668
            Console.WriteLine(Math.Log(Math.Exp(3))); // 3

            


        }
    }
}
