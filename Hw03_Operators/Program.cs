using System;

namespace Hw03_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *  İşlevlerine göre Operatörler 6 sınıfa ayrılır
             *      Aritmetik Operatörler(Arithmetic Operators)
             *      Karşılaştırma Operatörleri (Comparison Operators)
             *      Mantıksal Operatörler (Logical Operators)
             *      Bitsel Operatörler (Bitwise Operators)
             *      Atama ve İşlemli Atama Operatörleri (Assignment Operators)
             *      Özel Amaçlı Operatörler (Special Case Operators)
             */

            #region Aritmetik Operatörler
            /*
                Toplama, çıkarma gibi temel işlemleri yapan operatörlerdir
                    +, -, *, /, %, ++, --  
             */
            #endregion

            #region Karşılaştırma Operatörler
            /*
                İki sayı arasındaki büyüklük, küçüklük gibi ilişkileri kontrol eder.
                    >, <, <=, >=, ==, !=, as, is  
             */
            #endregion
            #region Mantıksal Operatörler
            /*
                Mantıksal işlemleri gerçekleştirir
                    ||, &&, !
             */
            #endregion
            #region Bitsel Operatörler
            /*
                Değişkenlere ilişkin değerlerin bitleri ile ilgili işlem yaparlar
                    |, &, ~, ^, <<, >>
             */
            #endregion
            #region Atama ve İşlemli atama Operatörleri
            /*
                Bir değişkene değer atamak için kullanılırlar
                    =, *=, /=, %= +=, -=, <<=, >>=, &=, ^=, |=
             */
            #endregion
            #region Özel Amaçlı Operatörler
            /*
                Bu gruptaki operatörlerin genel bir amacı yoktur. Her biri farklı amaçlar için kullanılmaktadır
                    ?:, (), [], +, -, &, *, ->, ., new, checked, unchecked, typeof, sizeof
             */
            #endregion

            // Operatörlerdeki işlem öncelik sıralaması matematikte sayılarla işlem yaparken ki işlem önceliği ile aynıdır

            #region ++, --, arttırma ve eksiltme operatör kullanımı
            // ++ veya -- yaparken bunu yaptığımız sayının değeri sadece atanacak ifade için değil, sayının kendisinde de değeri değiştirmektedir yani bir nevi ++, -- yapılan değişken için referans tip gibi davranmaktadır.

            int number1 = 10;
            int number2;
            int number3;
            number2 = number1++; // number2 ye, number1 in arttırılmadan önceki değeri atanıyor number2 = 10, ardından number1 sayısı 1 artırılıyor a=11
            number3 = ++number1; // number3 sayisina, number1 in değeri atanıyor, ilk olarak number1 artıyor number1=12; ardından number3'e atanıyor number3 = 12;
            Console.WriteLine($"a = {number1} \nb = {number2} \nc = {number3}");
            /*  Çıktı
                  number1 = 12
                  number2 = 10
                  number3 = 12
             */
            #endregion

            #region as - is Operatörü
            // as Operatörü çalışma zamanında uygun türler arası dönüşümü sağlar, dönüşüm işlemi başarısız olursa null döndürür
            object obj = "string-ifade";
            string str = obj as string; // işlem başarılıdır, str ifadesine "string-ifade" atanır
            Console.WriteLine(str);

            obj = 12;
            str = obj as string; // işlem başarısızdır. Null döndürür. str ifadesine null atanır
            Console.WriteLine(str); // Bişi yazamaz çünkü null yoktur. Olmayan bişi yazılamaz.(Hata vermez fakat çıktıda yoktur)

            //------------------------------------------
            // is Operatörü çalışma zamanında nesnenin türünün operand ile verilen türe uyumlu olup olmadığını kontrol eder
            int number = 40;
            bool kntNumber = number is int;     // true
            bool kntNumber2 = number is string; // false
            bool kntNumber3 = number is double; // false
            bool kntNumber4 = number is object; // true
            Console.WriteLine("kntnumber = " + kntNumber);
            Console.WriteLine("kntnumber2 = " + kntNumber2);
            Console.WriteLine("kntnumber3 = " + kntNumber3);
            Console.WriteLine("kntnumber4 = " + kntNumber4);
            #endregion

            #region Ternary Operatörü ( ?: ) -- aynı zamanda if-else in tek satırda kullanımıdır
            //  koşul = doğru-deger : yanlış-deger

            bool kntTernary = 5 < 2 ? true : false;     // 5, 2 den küçük değildir, : dan sonraki çalışacak kntTernary = false
            bool kntTernary2 = 5 > 2 ? true : false;    // 5, 2 den büyüktür, : dan önceki kısım çalışacak kntTernary2 = true

            int k = 2 == 2 ? 4 : 5; // 2 eşit midir 2 ye ? öyle ise k = 4, değilse k = 5; 
            #endregion
        }
    }
}
