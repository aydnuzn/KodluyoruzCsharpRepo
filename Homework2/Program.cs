using System;
using System.Collections;

namespace Homework2_Collections1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın.
            (ArrayList sınıfını kullanara yazınız.)
                Negatif ve numeric olmayan girişleri engelleyin.
                Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
                Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
            */

            ArrayList arrayPrime = new ArrayList();
            ArrayList arrayNonPrime = new ArrayList();
            int numbers = 0;
            do
            {
                Console.Write($"{numbers+1}. number = ");
                string numb = Console.ReadLine();

                if(IsNumberPositive(numb))
                {
                    int number = Convert.ToInt32(numb);
                    if (IsPrime(number))
                        arrayPrime.Add(number);
                    else
                        arrayNonPrime.Add(number);
                    numbers++;
                }
            } while (numbers!=20);

            arrayPrime.Sort();
            arrayPrime.Reverse();

            arrayNonPrime.Sort();
            arrayNonPrime.Reverse();

            Console.Write("Prime Number = ");
            foreach (int primeNumber in arrayPrime)
                Console.Write(primeNumber + " ");
            
            Console.Write("\nNon Prime Number = ");
            foreach (int nonPrimeNumber in arrayNonPrime)
                Console.Write(nonPrimeNumber + " ");
        }

        public static bool IsNumberPositive(string value)
        {
            int number;
            foreach (char ch in value)
            {
                if (char.IsDigit(ch))
                {
                    number = Convert.ToInt32(ch.ToString());
                    if (number < 0)
                        return false;
                }
                else
                    return false;
            }
            return true;
        }

        public static bool IsPrime(int number)
        {
            if (number <= 1) 
                return false;
            if (number == 2) 
                return true;

            for (int i = 3; i <= number/2; i++)
                if (number % i == 0)
                    return false;
            return true;
        }
    }
}
