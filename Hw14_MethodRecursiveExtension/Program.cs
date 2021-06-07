using System;

namespace Hw14_MethodRecursiveExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            // Recursive Method
            Console.WriteLine(ArithmaticOperations.Factorial(5)); // 5*4*3*2*1 = 120
            // Extension -> Extension method ile degerimizi yazıp nokta koydugumuzda karsimiza gelen daha onceden yazılmış methodlar gibi yeni parametreler üretmemizi sağlamaktadır. Extension methodlarda class ile method static olup, parametre kısmındaki ilk deger this anahtar kelimesi ile baslamalidir.
            string value = "Aydin Uzun";
            Console.WriteLine(value.CheckSpaces());
            Console.WriteLine(value.ChangeWhiteSpaces());

        }
    }

    class ArithmaticOperations
    {
        public static int Factorial(int number)
        {
            if (number == 0)
                return 1;
            return number * Factorial(number - 1);
        }
    }
    public static class Operations
    {
        public static bool CheckSpaces(this string value)
        {
            return value.Contains(" ");
        }
        public static string ChangeWhiteSpaces(this string value)
        {
            string[] array = value.Split(" ");
            return string.Join("-", array);
        }
    }
}
