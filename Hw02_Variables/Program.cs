using System;

namespace Hw02_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Min,max,byte value of variables
            Console.WriteLine($"long {sizeof(long)} byte --- long max degeri -> {long.MaxValue} -- long min degeri -> {long.MinValue}");
            Console.WriteLine($"ulong {sizeof(ulong)} byte --- ulong max degeri -> {ulong.MaxValue} -- ulong min degeri -> {ulong.MinValue}\n");
            Console.WriteLine($"int {sizeof(int)} byte --- int max degeri -> {int.MaxValue} -- int min degeri -> {int.MinValue}");
            Console.WriteLine($"uint {sizeof(uint)} byte --- uint max degeri -> {uint.MaxValue} -- uint min degeri -> {uint.MinValue}\n");
            Console.WriteLine($"short {sizeof(short)} byte --- short max degeri -> {short.MaxValue} -- short min degeri -> {short.MinValue}");
            Console.WriteLine($"ushort {sizeof(ushort)} byte --- ushort max degeri -> {ushort.MaxValue} -- ushort min degeri -> {ushort.MinValue}\n");
            Console.WriteLine($"byte {sizeof(byte)} byte --- byte max degeri -> {byte.MaxValue} -- byte min degeri -> {byte.MinValue}");
            Console.WriteLine($"sbyte {sizeof(sbyte)} byte --- sbyte max degeri -> {sbyte.MaxValue} -- sbyte min degeri -> {sbyte.MinValue}\n");
            Console.WriteLine($"float {sizeof(float)} byte --- float max degeri -> {float.MaxValue} -- float min degeri -> {float.MinValue}");
            Console.WriteLine($"double {sizeof(double)} byte --- double max degeri -> {double.MaxValue} -- double min degeri -> {double.MinValue}");
            Console.WriteLine($"decimal {sizeof(decimal)} byte --- decimal max degeri -> {decimal.MaxValue} -- decimal min degeri -> {decimal.MinValue}\n");
            Console.WriteLine($"char {sizeof(char)} byte");


            string str = "String Ifade";
            string str1 = string.Empty;
            string name = "Ihsan";
            string surname = "Soylu";
            string fullName = name + " " + surname;
            Console.WriteLine(fullName);

            bool control1 = true;
            bool control2 = false;

            DateTime dt = DateTime.Now;

            object o1 = 'a';
            object o2 = "manager";
            object o3 = 4;
            object o4 = 4.3;

            //TODO: string to int
            string number1 = "1254";
            int number2 = Convert.ToInt32(number1);
            Console.WriteLine(number2);

            //TODO: Datetime
            string datetime1 = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine("\ndatetime = "+datetime1);
            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine("datetime = " + datetime2);
            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine("datetime = " + hour);
        }
    }
}
