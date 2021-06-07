using Hw26_Interface.Car;
using System;

namespace Hw26_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            LogManager logManager = new LogManager(new DatabaseLogger());
            logManager.WriteLog();
            LogManager logManager2 = new LogManager(new FileLogger());
            logManager2.WriteLog();
            LogManager logManager3 = new LogManager(new SmsLogger());
            logManager3.WriteLog();

            Console.WriteLine("\n");
            //********************************************************
            Focus focus = new Focus();
            Console.WriteLine(focus.Brand());
            Console.WriteLine(focus.StandardColor());
            Console.WriteLine(focus.WheelsNumber());

            Civic civic = new Civic();
            Console.WriteLine(civic.Brand());
            Console.WriteLine(civic.StandardColor());
            Console.WriteLine(civic.WheelsNumber());

        }
    }
}
