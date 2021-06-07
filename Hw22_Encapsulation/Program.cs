using System;

namespace Hw22_Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student()
            {
                Name = "Aydin",
                Surname = "Uzun",
                No = 5234324
            };
            student.StudentInfo();
        }
    }
    class Student
    {
        private string _Name;
        private string _Surname;
        private int _No;
        public string Name 
        {
            get { return "Sayin "+_Name; }
            set { _Name = value; }  
        }
        public string Surname { get =>_Surname; set=>_Surname = value; }
        public int No { get=>_No; set=>_No=value; }

        public Student()
        {
        }

        public Student(string name, string surname, int no)
        {
            Name = name;
            Surname = surname;
            No = no;
        }
        public void StudentInfo()
        {
            Console.WriteLine("***Student Info***");
            Console.WriteLine($"Student Name    : {Name}");
            Console.WriteLine($"Student Surname : {Surname}");
            Console.WriteLine($"Student No      : {No}");
        }
    }
}
