using System;

namespace Hw20_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Access Modifiers
             * Public
             * Private
             * Internal
             * Protected
            */

            Employee employee = new Employee()
            {
                Name = "Aydin",
                Surname = "Uzun",
                No = 31523563,
                Department = "IT"
            };
            Employee employee2 = new Employee()
            {
                Name = "Hasan",
                Surname = "Soran",
                No = 36734254,
                Department = "Human Resources"
            };

            employee.EmployeeInfo();
            Console.WriteLine("**********************");
            employee2.EmployeeInfo();

        }
    }

    class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int No { get; set; }
        public string Department { get; set; }

        public void EmployeeInfo()
        {
            Console.WriteLine($"Employee Name: {Name}");
            Console.WriteLine($"Employee Surname: {Surname}");
            Console.WriteLine($"Employee No: {No}");
            Console.WriteLine($"Employee Department: {Department}");
        }

    }
}
