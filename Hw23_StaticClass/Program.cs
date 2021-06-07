using System;

namespace Hw23_StaticClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Employee Number : {Employee.EmployeNumber}");

            Employee employee = new Employee("Aydin","Uzun","IT");
            Console.WriteLine($"Employee Number : {Employee.EmployeNumber}");
            Employee employee2 = new Employee("Aydin2", "Uzun2", "IT2");
            Employee employee3 = new Employee("Aydin3", "Uzun3", "IT3");
            Employee employee4 = new Employee("Aydin4", "Uzun4", "IT4");
            Console.WriteLine($"Employee Number : {Employee.EmployeNumber}");

            // Static siniflarin içinde static olmayan degerler kullanilamaz. Static siniflara kalitim uygulanamaz. Static siniflarin ornegi olusturulamaz(new lenemez / instance'si oluşturulamaz)
            Console.WriteLine("\n"+Arithmetic.Addition(100,45));    // 145
            Console.WriteLine(Arithmetic.Subtract(40,14));          // 26
        }
    }

    class Employee
    {
        private static int _EmployeeNumber;
        public static int EmployeNumber { get => _EmployeeNumber; }
        private string _Name;
        private string _Surname;
        private string _Department;

        static Employee()
        {
            _EmployeeNumber = 0;
        }
        public Employee(string name, string surname, string department)
        {
            _Name = name;
            _Surname = surname;
            _Department = department;
            _EmployeeNumber++;
        }
    }

    static class Arithmetic
    {
        public static long Addition(int number1, int number2)
        {
            return number1 + number2;
        }
        public static long Subtract(int number1, int number2)
        {
            return number1 - number2;
        }
    }
}
