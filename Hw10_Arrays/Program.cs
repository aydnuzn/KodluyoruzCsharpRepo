using System;

namespace Hw10_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array Definition
            string[] colors = new string[5];
            colors[0] = "black";
            colors[1] = "green";
            colors[2] = "red";
            colors[3] = "blue";
            colors[4] = "gray";

            string[] animals = { "Cat", "Dog", "Bird", "Monkey" };

            Console.WriteLine(animals[2]); // Bird
            Console.WriteLine(colors[3]); // Blue

            Console.Write("Enter Array Size: ");
            int arraySize = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                Console.Write($"{i+1}. elemani giriniz = ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            int sum = 0;
            // Sum of array elements
            foreach (int item in array)
                sum += item;
            Console.WriteLine($"Sum of array elements: {sum}");

        }
    }
}
