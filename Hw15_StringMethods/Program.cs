using System;
using System.Collections.Generic;

namespace Hw15_StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string strValue = "Welcome to Csharpadskkladslkda";
            string strValue2 = "Welcome to Java";

            // Length
            Console.WriteLine(strValue.Length);

            // ToUpper and ToLower
            Console.WriteLine(strValue.ToUpper()); // WELCOME TO CSHARP
            Console.WriteLine(strValue.ToLower()); // welcome to csharp

            // Concat
            Console.WriteLine(string.Concat(strValue,"9.0"));  // Welcome to Csharp9.0

            // Compare, CompareTo
            var ss = strValue.CompareTo(strValue2); // strValue nin karakter sayısı buyukkende kucukkende -1 donuyor?
            Console.WriteLine(strValue.CompareTo(strValue2)); // 1. degisken 2. degiskene esit ise 0 doner,
                                                              // 1. degiskenin karakter sayisi, 2. degiskeninkinden buyukse 1 doner,
                                                              // 1. degiskenin karakter sayisi, 2. degiskeninkinden kucukse -1 doner.
            string temp1 = "dErS BasLadi";
            string temp2 = "ders basladi";
            Console.WriteLine(string.Compare(temp1,temp2,true));    // 0 -> En sagdaki true, buyuk-kucuk harfe dikkat etmesi gerektigini soyluyor
            Console.WriteLine(string.Compare(temp1, temp2, false)); // 1 -> En sagdaki false, buyuk-kucuk harfe dikkat etmemesi gerektigini soyluyor

            // Contains
            string FullName = "Aydin0U-z,un";
            List<char> IsCharacterControl = new List<char>(){
                '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '-',','
            };
            for (int i = 0; i < FullName.Length; i++)
            {
                if (IsCharacterControl.Contains(FullName[i]))   //Icinde var mi diye kontrol ediyor. Varsa true, yoksa false
                    Console.WriteLine($"{FullName[i]} - Bulundu");
            }

            // IndexOf
            Console.WriteLine(strValue.IndexOf("Cs")); // 11 -> Ilk buldugu yerin index ini donecek
            Console.WriteLine(strValue.IndexOf("Csw")); // -1 -> , Bulamaz ise -1 doner.

            // LastIndexOf -> ustteki gibi calisir ama aramaya sondan baslar, ilk gordugu yerin index ini alir.

            // Insert
            Console.WriteLine(strValue.Insert(1,"ee")); // Weeelcome to Csharpadskkladslkda -> ekleme yapacagımız yeri belirleyip eklemeyi yapiyoruz.

            //PadLeft, PadRight
            string strTemp1 = "Ad";
            string strTemp2 = "Memleket";
            Console.WriteLine(strTemp1.PadLeft(10) + ":");  //        Ad:   PadLeft, sola dayali belirtilen alan kadar alan birakiyor
            Console.WriteLine(strTemp2.PadLeft(10) + ":");  //  Memleket:

            Console.WriteLine(strTemp1.PadRight(10) + ":"); // Ad        :  PadRight, saga dayali belirtilen kadar alan birakiyor
            Console.WriteLine(strTemp2.PadRight(10) + ":"); // Memleket  :

            Console.WriteLine(strTemp1.PadLeft(10,'*') + ":"); // ********Ad:
            Console.WriteLine(strTemp2.PadLeft(10,'-') + ":"); // --Memleket:

            Console.WriteLine(strTemp1.PadRight(10, '*') + ":"); // Ad********:
            Console.WriteLine(strTemp2.PadRight(10, '-') + ":"); // Memleket--:


            // Remove
            string newStrValue = "Operators";
            Console.WriteLine(newStrValue.Remove(3));   // Ope
            Console.WriteLine(newStrValue.Remove(3,2)); // Opetors

            //Replace
            string newStrValue1 = "Ope ra tors";
            Console.WriteLine(newStrValue1.Replace(" ",""));   // Operators
            Console.WriteLine(newStrValue1.Replace(" ", "-"));   // Ope-ra-tors

            //Split -> Belirtilen karakteri gordugunde, cumleyi bolup array e sirasiyla yolluyor
            string[] word = newStrValue1.Split(" ");
            // word[0] = Ope;
            // word[1] = ra;
            // word[2] = tors;

            // Substring
            string lastStr = "Last String Operators";
            Console.WriteLine(lastStr.Substring(7)); // ring Operators -> Belirtilen indexten sona kadar alir.
            Console.WriteLine(lastStr.Substring(0,3)); // Las -> Belirtilen indexten, belirtilen uzunluk kadar alir

        }
    }
}
