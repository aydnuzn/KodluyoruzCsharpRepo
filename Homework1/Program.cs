using System;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

            Console.Write("Enter positive number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[number];
            for (int i = 0; i < number; i++)
            {
                Console.Write($"Enter the {i+1}. positive number: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int nmbr in array)
                Console.Write(nmbr % 2 == 0 ? nmbr+" " : "");

            // 2. Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
            Console.Write("Enter the  positive number-1: ");
            int example2Number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the  positive number-2: ");
            int example2Number2 = Convert.ToInt32(Console.ReadLine());

            int[] example2Array = new int[example2Number1];
            for (int i = 0; i < example2Number1; i++)
            {
                Console.Write($"Enter the {i + 1}. positive number: ");
                example2Array[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int nmbr in example2Array)
                Console.Write(nmbr % example2Number2 == 0 ? nmbr + " " : "");


            // 3. Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
            Console.Write("Enter the  positive number: ");
            int example3Number = Convert.ToInt32(Console.ReadLine());
            string[] words = new string[example3Number];
            for (int i = 0; i < example3Number; i++)
            {
                Console.Write($"Enter the {i + 1}. word: ");
                words[i] = Console.ReadLine();
            }
            words.myReverse();
            foreach (string word in words)
                Console.WriteLine(word);


            // 4. Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
            Console.Write("Enter the Sentence: ");
            string sentence = Console.ReadLine();
            string[] example4words = sentence.Split(" ");
            Console.Write($"Total Word Count = {example4words.Length}\n");
            int characterCount = (string.Join("", example4words)).Length;
            Console.Write($"Total Character Count = {characterCount}");

        }
    }
    public static class Operations
    {
        public static string[] myReverse(this string[] words)
        {
            string temp = string.Empty;
            for (int i = 0; i < words.Length / 2; i++)
            {
                temp = words[i];
                words[i] = words[words.Length-1 - i];
                words[words.Length-1 - i] = temp;
            }
            return words;
        }
    }
}
