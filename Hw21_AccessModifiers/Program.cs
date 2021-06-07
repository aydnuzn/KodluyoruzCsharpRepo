using System;

namespace Hw21_AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
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
            Console.WriteLine("**********************");
            // Constructor
            Employee employee3 = new Employee("Zeynep","Tek",48243435,"Design");
            employee3.EmployeeInfo();

        }
    }
    class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int No { get; set; }
        public string Department { get; set; }
        public Employee()
        {
        }
        public Employee(string name, string surname, int no, string department)
        {
            this.Name = name;
            this.Surname = surname;
            this.No = no;
            this.Department = department;
        }

        public void EmployeeInfo()
        {
            Console.WriteLine($"Employee Name: {Name}");
            Console.WriteLine($"Employee Surname: {Surname}");
            Console.WriteLine($"Employee No: {No}");
            Console.WriteLine($"Employee Department: {Department}");
        }

    }
}
