using System;

namespace Hw12_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 2;
            int number2 = 3;
            Console.WriteLine(number1+number2); // 2+3 = 5
            Method.IncementalSum(ref number1, ref number2);
            Console.WriteLine(number1 + number2); // 3 + 4 = 7

            int result = Sum(number1,number2);

            string valueStr = @"denklem/islem";
            Method.Display(valueStr);
        }

        public static int Sum(int number1,int number2)
        {
            return number1 + number2;
        }
    }

    class Method
    {
        public static void Display(string data)
        {
            Console.WriteLine(data);
        }

        public static void IncementalSum(ref int numb1, ref int numb2)
        {
            numb1++;
            numb2++;
        }

    }
}
