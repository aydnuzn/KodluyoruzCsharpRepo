using System;
using System.Collections.Generic;

namespace Hw09_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            do
            {
                Console.Write("TC Kimlik No giriniz(Exit to '0'): ");
                customer.IdentityNumber = Console.ReadLine();
                if (customer.IdentityNumber != null && customer.IdentityNumber.Equals("0"))
                    break;
                

                Console.WriteLine("");

            } while (customer.IdentityNumber == null);

            // square drawing
            Console.Write("Enter Number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                    Console.Write("*");
                Console.WriteLine();
            }

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach (int nmbr in numbers)
                Console.Write(nmbr + " ");

            Console.WriteLine();

            //a' dan z' dahil yazdirma
            char character = 'a';
            while (character <= 'z')
                Console.Write(character++);

        }
    }
}
