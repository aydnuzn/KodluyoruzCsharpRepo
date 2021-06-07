using System;
using System.Collections;

namespace Homework2_Collections2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, 
                       her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama 
                       toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)
             */

            ArrayList numberList = new ArrayList();
            int numbers = 0;
            do
            {
                try
                {
                    Console.Write($"{numbers + 1}. number = ");
                    int numb = Convert.ToInt32(Console.ReadLine());
                    numberList.Add(numb);
                    numbers++;
                }
                catch (Exception ex)
                {
                    if(ex.HResult == -2146233033)
                        Console.WriteLine("Sadece Rakam Giriniz.");
                }
            } while (numbers != 20);

            numberList.Sort();
            ArrayList enb = new ArrayList();
            ArrayList enk = new ArrayList();
            int enbSum = 0;
            int enkSum = 0;
            for (int i = 0; i <= 2 ; i++)
            {
                enbSum += (int)numberList[numberList.Count - 1 - i];
                enkSum += (int)numberList[i];
                enb.Add(numberList[numberList.Count-1-i]);
                enk.Add(numberList[i]);
            }
            

            Console.Write($"En büyük 3 sayi = {enb[0]} {enb[1]} {enb[2]} \n" +
                              $"En kucuk 3 sayi = {enk[0]} {enk[1]} {enk[2]} \n" +
                              $"En buyuk 3 sayi ortalamasi = {enbSum/3.0}\n" +
                              $"En kucuk 3 sayi ortalamasi = {enkSum/3.0}\n" +
                              $"En buyuk ve En kucuk 3 sayi ortalamasi toplami = {enbSum / 3.0 + enkSum / 3.0}");
        }
    }
}
