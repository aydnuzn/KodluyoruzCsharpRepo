using System;
using System.Collections;
using System.Collections.Generic;

namespace Hw18_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            // ArrayList farkli veri tipleri alabilir.
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Aydin");
            arrayList.Add(13);
            arrayList.Add(true);
            arrayList.Add('d');

            // Accessing the data
            Console.WriteLine("Second index = " + arrayList[2]);

            foreach (var item in arrayList)
                Console.WriteLine(item + " ");

            Console.WriteLine();

            // AddRange
            Console.WriteLine("*** Add Range ***");
            string[] colors = { "Red", "Blue", "Orange", "Yellow" };
            List<int> numbers = new List<int>(){ 1, 9, 5, 2, 4 };
            arrayList.AddRange(colors);
            arrayList.AddRange(numbers);
            foreach (var item in arrayList)
                Console.Write(item + " ");

            Console.WriteLine();

            // Sort
            // arrayList.Sort(); icerisinde sadece sayisal degerler varken kucukten buyuge siralar, diger turlu hata verecektir.

            // Binary Search
            // Console.WriteLine(arrayList.BinarySearch(4)); arrayList imin icinde bir cok tur oldugu icin hata verecektir. Bu arama surekli orta kisma gidip aranmak istenilen degeri karsilastirir buyuk mu kucuk mu diye bakar simdi 4 int rakamını arasam arrayList icinde arama yaparken, string ifadeye gelip 4 degeri ile karsilastirmaya calisabilir, ture olan bool degisken turune gidip yine int 4 olan deger ile karsilastirma yapmaya calisabilir. Haliyle hata alıcam cunku dege tipleri farkli

            // Reverse -> elemanlari ters cevirir. 1. deki sona, sondaki de basa gelicek sekilde elemanlar siralanir
            Console.WriteLine("***Reverse***");
            foreach (var item in arrayList)
                Console.Write(item + " ");
            Console.WriteLine();
            arrayList.Reverse();
            foreach (var item in arrayList)
                Console.Write(item + " ");

            Console.WriteLine();

            // Clear
            Console.WriteLine("***arrayList.Clear()***");
            arrayList.Clear();
            foreach (var item in arrayList)
                Console.Write(item + " ");
        }
    }
}
