using System;

namespace Hw04_TypeConversions
{
    class Program
    {
        static void Main(string[] args)
        {

            // Bilinçsiz Tür dönüşümü (Implicit Conversion)
            Console.WriteLine("***Implicit Conversion***");
            string str = "aydin";
            char ch = 'e';
            object baseValue = str + ch;
            Console.WriteLine(baseValue);

            /*----------------------------------------------------------------------*/

            // Bilinçli tür dönüşümü (Explicit Conversion)
            Console.WriteLine("***Explicit Conversion***");
            int nmbr = 134;
            byte nmbr1 = (byte)nmbr;
            Console.WriteLine("nmbr1 = " + nmbr1);

            float fltValue = 10.3f;
            byte bytValue = (byte)fltValue;
            Console.WriteLine("bytValue = " + bytValue);

            /* Parse ve Convert */
            string sayi = "10";
            int number1 = int.Parse(sayi);
            int number2 = Convert.ToInt32(sayi);

            // Hemen üstte Parse ve Convert ile 2 string ifadeyi sayiya çeviriyoruz aralarındaki fark aşağıdaki gibidir
            string text1 = "232";
            string text2 = null;

            int sayi1 = -1;
            int sayi2 = -1;

            // Convert.ToInt32 kullanımı
            sayi1 = Convert.ToInt32(text1);
            sayi2 = Convert.ToInt32(text2); // text2, null olmasına rağmen bana null değer sayiya dönüşemez demedi otomatikmen 0 sayısını sayi2 ye atadı.   
            // Değişkenin içindeki kısmı hata verecekmi cevrilebilecek mi diye baktı ve int ın default değeri olan 0 ı buraya hatadı.
            // Databaseden veya farklı bir dosyadan dataları okurken tip dönüşümlerinde hata almamak için Convert kullanabiliriz.

            // Alttaki int.Parse de ise hata verir. Atama işlemi gerçekleşmez.
            // int.Parse kullanımı
            sayi1 = int.Parse(text1);
            sayi2 = int.Parse(text2);  // Burada int.Parse içi null olamaz diye hata veriyor

        }
    }
}
