using System;
using System.Collections.Generic;

namespace Homework2_Collections3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Soru - 3: Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve 
                       dizinin elemanlarını sıralayan programı yazınız.
             */

            List<char> vowelList = new List<char>() { 'a', 'e', 'i', 'o', 'u'};
            List<char> chList = new List<char>();

            Console.Write("Write sentence : ");
            string sentence = Console.ReadLine();
            foreach (char ch in sentence)
                if (vowelList.Contains(ch))
                    if(!chList.Contains(ch))
                        chList.Add(ch);
            
            chList.Sort();
            foreach (var item in chList)
                Console.Write(item + " ");
        }
    }
}
