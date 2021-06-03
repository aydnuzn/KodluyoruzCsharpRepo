using System;
using System.Collections.Generic;

namespace Hw05_ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> HataKodları = new List<int>()
            {
                -2146233033,-2146233066
            };

            int control;
            do
            {
                control = 0;
                try
                {   // Standart Uygulama için yazmış olduğumuz kod blogları
                    HataYonetimi();
                }
                catch (Exception ex)
                {   // Catch blogları sistem içerisinde çalışma zamanında alınan hataların loglanması ve kullanıcıya daha açıklayıcı hata mesajları vermemize yarayan bloklardır
                    Console.ForegroundColor = ConsoleColor.Red;

                    control = ex.HResult;
                    if (control == -2146233033)
                        Console.WriteLine("Lütfen sadece rakam giriniz");
                    if (control == -2146233066)
                        Console.WriteLine("int değişkenin tutabileceği veri aralığının dışına çıktınız,\n" +
                            "Girdiğiniz sayı Pozitif ise daha küçük, Negatif ise daha büyük bir sayı girişi yapınız");

                    Console.WriteLine(ex.Message);
                    Console.ResetColor(); // Atanılan rengi temizler
                }
                finally
                {
                    // Try --> Kodlarımız çalışır
                    // Catch --> Hata alırsak burası çalışır
                    // Finally --> Hata alalım veya almayalım, burası her türlü çalışıyor

                    // Bu finally kısmında ne yapabiliriz --> Try kısmında database bağlantısı yaptığımızda kodumuz çalışırken databaseye bağlandık ve bağlantıyı kapamadan hata aldık o zaman direk catch e düşeriz ve bağlantımızıda kapatamamış oluyoruz. Bu bağlantıyı finally kısmında kapatırız. Yani Try kısmında açtığımız şeyleri Finally kısmında kapatmak isteriz. Çünkü hata alalım veya almayalım her türlü burası çalışır

                }
            } while (HataKodları.Contains(control)); // HataKodları içinde control değeri var ise döngüye tekrar girecek

            Console.WriteLine("İşlem devam edecek...");
        }
        static void HataYonetimi()
        {
            Console.Write("Sayi Giriniz = ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
        }
    }
}
