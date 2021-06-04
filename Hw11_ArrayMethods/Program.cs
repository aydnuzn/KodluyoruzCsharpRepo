using System;

namespace Hw11_ArrayMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 5, 3, 4, 9, 6, 7, 8, 2 };

            foreach (var number in numbers)
                Console.WriteLine(number);

            // Array Size
            int arrayLength = numbers.Length;

            // Kucukten buyuge siralama
            Array.Sort(numbers); 

            // Ters cevirme
            Array.Reverse(numbers);

            // Belirtilen elemanlari sifirlar
            Array.Clear(numbers, 1, 3);

            // indexof -> array icindeki degerlerin kacinci index'te oldugunu verir, yoksa -1 verir.
            int arrayIndex = Array.IndexOf(numbers,999);

            // resize -> diziyi yediden boyutlandirir.
            Array.Resize<int>(ref numbers, 10);
            numbers[9] = 111;

            foreach (var item in numbers)
                Console.Write(item+" ");

            


        }
    }
}
