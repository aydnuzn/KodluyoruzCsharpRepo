using System;
using System.Collections.Generic;

namespace Hw17_GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<T>  --  T -> object type

            List<int> numberList = new List<int>() { 23, 10, 4, 5, 92, 34 };
            List<string> colorList = new List<string>() { "Red", "Blue", "Orange", "Yellow" };

            // Count
            Console.WriteLine(numberList.Count);    // 6
            Console.WriteLine(numberList.Capacity); // 8
            Console.WriteLine(colorList.Count);     // 4
            Console.WriteLine(colorList.Capacity);  // 4

            // foreach and List.ForEach -- List elements
            foreach (int number in numberList)
                Console.Write(number + " ");    // 23 10 4 5 92 34
            Console.WriteLine();
            foreach (string color in colorList)
                Console.Write(color + " ");     // Red Blue Orange Yellow
            Console.WriteLine();

            numberList.ForEach(number => Console.Write(number + " "));  // 23 10 4 5 92 34
            Console.WriteLine();
            colorList.ForEach(color => Console.Write(color + " "));     // Red Blue Orange Yellow

            // Deleting an element from the list
            var numberControl = numberList.Remove(35);  // belitilen sayi yoksa false doner, varsa true doner ve sayiyi siler
            colorList.Remove("Orange"); Console.WriteLine();
            numberList.ForEach(number => Console.Write(number + " "));  // 23 10 4 5 92 34
            Console.WriteLine();
            colorList.ForEach(color => Console.Write(color + " "));     // Red Blue Yellow
            Console.WriteLine();

            numberList.RemoveAt(0);
            colorList.RemoveAt(0);
            numberList.ForEach(number => Console.Write(number + " "));  // 10 4 5 92 34
            Console.WriteLine();
            colorList.ForEach(color => Console.Write(color + " "));     // Blue Yellow

            Console.WriteLine();

            // Search within the list
            if (numberList.Contains(92))
                Console.WriteLine("Liste icerisinde 92 vardir.");

            // find the index
            // BinarySearch 2'li arama yapar. Dizinin ortasındaki eleman ile bulmak istediği sayiya bakar bulmak istediği eleman daha buyuk ise dizinin orta kısmından sol kısmını alıp yine burada sürekli orta noktalara gide gide değeri bulmaya çalışır, bu arama çeşidi sıralanmış veriler için kullanılması performans açısından hız kazandırır ama sıralanmamış dizilerde BinarySearch ile arama yapılması önerilmez. IndexOf kullanılması daha makuldur.
            Console.WriteLine(colorList.BinarySearch("Yellow"));    // 1
            Console.WriteLine(colorList.IndexOf("Yellow"));         // 1


            // Array to List
            string[] animals = { "Cat", "Dog", "Fish", "Bird", "Leo" };
            List<string> animalList = new List<string>(animals);

            // List clear
            animalList.Clear();

            // Keeping an object in a list
            List<Users> userList = new List<Users>();
            Users user1 = new Users()
            {
                Name = "Aydin",
                Surname = "Uzun"
            };
            Users user2 = new Users()
            {
                Name = "Aydin2",
                Surname = "Uzun2"
            };
            userList.Add(user1);
            userList.Add(user2);

            foreach (Users user in userList)            
                Console.WriteLine($"User Name = {user.Name.PadRight(6)} -- User Surname = {user.Surname}");
            

        
        }
    }

    public class Users
    {
        private string _name;
        private string _surname;

        public string Name { get =>_name; set => _name = value; }
        public string Surname { get => _surname; set => _surname = value; }

    }
}
