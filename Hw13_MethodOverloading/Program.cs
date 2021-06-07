using System;

namespace Hw13_MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            // out parameters
            string number1 = "50";
            string number2 = "str5k0";

            bool number1Control = int.TryParse(number1, out int result);    // true
            Console.WriteLine("result = " + result);    // result = 50
            bool number2Control = int.TryParse(number2, out int result2);   // false
            Console.WriteLine("result2 = " + result2);  // result = 0

            // Overloading
            Display(2); // 2
            Display("number"); // number
            Display("number", " = 3"); // number = 3

        }

        public static void Display(int value)
        {
            Console.WriteLine(value);
        }

        public static void Display(string value)
        {
            Console.WriteLine(value);
        }

        public static void Display(string value1, string value2)
        {
            Console.WriteLine(value1 + value2);
        }
    }
}
