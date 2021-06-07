using System;

namespace Hw07_DecisionStructure_SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;
            //month = 13;
            switch (month)
            {
                case 1: Console.WriteLine("Ocak"); break;
                case 2: Console.WriteLine("Subat"); break;
                default:    // Default en asagıda olmak zorunda degil hicbir durum gerceklesmez ise o zaman default'a girer
                    Console.WriteLine("Yanlis veri girisi");
                    break;
                case 3: Console.WriteLine("Mart");  break;
                case 4: Console.WriteLine("Nisan"); break;
                case 5: Console.WriteLine("Mayis"); break;
                case 6: Console.WriteLine("Haziran"); break;
                case 7: Console.WriteLine("Temmuz"); break;
                case 8: Console.WriteLine("Ağustos"); break;
                case 9: Console.WriteLine("Eylul"); break;
                case 10: Console.WriteLine("Ekim"); break;
                case 11: Console.WriteLine("Kasim"); break;
                case 12: Console.WriteLine("Aralik"); break;

                
            }
        }
    }
}
