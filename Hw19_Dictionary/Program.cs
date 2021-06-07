using System;
using System.Collections.Generic;

namespace Hw19_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> users = new Dictionary<int, string>();
            users.Add(10, "Ali Demir");
            users.Add(12,"Ertugrul Balbars");
            users.Add(19, "Enes Babayev");
            users.Add(24, "Melis Degimenci");

            // Accessing the data
            Console.WriteLine(users[19]);
            foreach (var item in users)
                Console.WriteLine(item);

            // Count
            Console.WriteLine(users.Count);

            // Contains
            Console.WriteLine("***Contains***");
            Console.WriteLine(users.ContainsKey(19));
            Console.WriteLine(users.ContainsValue("Ali Demir"));

            // Remove
            Console.WriteLine("***Remove***");
            users.Remove(12);
            foreach (var item in users)
                Console.WriteLine(item.Value);

            // Keys
            Console.WriteLine("***Keys***");
            foreach (var item in users.Keys)
                Console.WriteLine(item);

            // Values
            Console.WriteLine("***Values***");
            foreach (var item in users.Values)
                Console.WriteLine(item);
            
        }
    }
}
