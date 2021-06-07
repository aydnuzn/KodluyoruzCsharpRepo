using System;
using System.Collections.Generic;
using System.Linq;

namespace Project1_PhoneBookApp
{
    class Program
    {
        static List<Person> personList;
        static int secim = 0;
        static string name, surname, no;
        static string tempInfo = string.Empty;
        static bool isDelete = false;
        static bool isUpdate = false;
        static void Main(string[] args)
        {
            personList = new List<Person>()
            {
                new Person{Name = "Aydin", Surname = "Uzun", TelephoneNumber="8425689314"},
                new Person{Name = "Gizem", Surname = "Degirmenci", TelephoneNumber="4352464584"},
                new Person{Name = "Berna", Surname = "Gozlu", TelephoneNumber="6351431123"},
                new Person{Name = "Bekir", Surname = "Caliskan", TelephoneNumber="8742517373"},
                new Person{Name = "Mert", Surname = "Kucuk", TelephoneNumber="9104239216"}
            };

            List<int> ErrorCode = new List<int>()
            {
                -2146233033, -2146233088
            };
            int control = 0;
        //    int secim = 0;

            do
            {
                control = 0;
                try
                {
                    SelectAction();
                    //    if (secim <= 0 || secim > 5)
                    //        throw new(string.Format("1-5 arasi seçim yapiniz"));
                    switch (secim)
                    {
                        case 1:
                            AddNumber();
                            break;

                        case 2:
                            DeleteNumber();
                            break;

                        case 3:
                            UpdateNumber();
                            break;

                        case 4:
                            DisplayNumber();
                            break;

                        case 5:
                            FindNumber();
                            break;

                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("1-5 arasi secim yapiniz..");
                            Console.ResetColor();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    control = ex.HResult;
                    if (control == -2146233088)
                        Console.WriteLine(ex.Message);
                    else if (control == -2146233033)
                        Console.WriteLine("Lütfen sadece rakam giriniz");
                    else
                        Console.WriteLine(ex.Message);

                    Console.ResetColor(); // Atanılan rengi temizler
                }
            } while (true);
        }

        static void SelectAction()
        {
            Console.WriteLine("\nLutfen yapmak istediğiniz işlemi seçiniz :");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");
            Console.Write("Seciminiz = ");
            secim = Convert.ToInt32(Console.ReadLine());
        }

        static void AddNumber()
        {
            Console.Write("Lutfen Adinizi Giriniz".PadRight(34) + ":");
            name = Console.ReadLine();
            Console.Write("Lutfen Soyadinizi Giriniz".PadRight(34) + ":");
            surname = Console.ReadLine();
            Console.Write("Lutfen Telefon Numaranizi Giriniz".PadRight(34) + ":");
            no = Console.ReadLine();
            personList.Add(new Person { Name = name, Surname = surname, TelephoneNumber = no });
        }

        static void DeleteNumber()
        {
            int choice = 0;
            isDelete = false;
            do
            {
                Console.Write("Lutfen numarasini silmek istediginiz kisinin adini ya da soyadini giriniz : ");
                tempInfo = Console.ReadLine();
                foreach (Person person in personList)
                {
                    if (person.Name.Equals(tempInfo) || person.Surname.Equals(tempInfo))
                    {
                        personInfo(person);
                        Console.WriteLine("kisisi rehberden silinmek üzere, onayliyor musunuz ?(y/n)");
                        string deleteChoice = Console.ReadLine().ToUpper();
                        if (deleteChoice.Equals("Y"))
                        {
                            personList.Remove(person);
                            isDelete = true;
                            Console.WriteLine("Silindi.");
                        }
                        else
                            isDelete = true;
                        break;
                    }
                }
                if (!isDelete)
                {
                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız." +
                        "\n* Silmeyi sonlandirmak icin".PadRight(26) + ": (1)" +
                        "\n* Yeniden denemek icin".PadRight(26) + ": (2)");
                    choice = Convert.ToInt32(Console.ReadLine());
                }
            } while (choice == 2);
        }

        static void UpdateNumber()
        {
            int choice2 = 0;
            isUpdate = false;
            do
            {
                Console.Write("Lutfen numarasini guncellemek istediginiz kisinin adini ya da soyadini giriniz : ");
                tempInfo = Console.ReadLine();
                foreach (Person person in personList)
                {
                    if (person.Name.Equals(tempInfo) || person.Surname.Equals(tempInfo))
                    {
                        personInfo(person);
                        Console.WriteLine("kisisi telefonu guncellenemek üzere, onayliyor musunuz ?(y/n)");
                        string updateChoice = Console.ReadLine().ToUpper();
                        if (updateChoice.Equals("Y"))
                        {
                            Console.Write("Yeni Telefon Numarasini Giriniz: ");
                            string newNo = Console.ReadLine();
                            personList[personList.IndexOf(person)].TelephoneNumber = newNo;
                            isUpdate = true;
                            Console.WriteLine("Telefon numarasi guncellendi.");
                        }
                        else
                            isUpdate = true;
                        break;
                    }
                }
                if (!isUpdate)
                {
                    Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız." +
                        "\n* Guncellemeyi sonlandirmak icin".PadRight(32) + ": (1)" +
                        "\n* Yeniden denemek icin".PadRight(32) + ": (2)");
                    choice2 = Convert.ToInt32(Console.ReadLine());
                }
            } while (choice2 == 2);
        }
        static void DisplayNumber()
        {
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("**********************************************");
            foreach (Person person in personList)
            {
                personInfo(person);
                if (personList.IndexOf(person) + 1 != personList.Count)
                    Console.WriteLine("-");
            }
        }
        static void FindNumber()
        {
            Console.WriteLine("Arama yapmak istediginiz tipi seciniz.");
            Console.WriteLine("**********************************************");
            Console.WriteLine("Isim veya soyisime göre arama yapmak için: (1)\n" +
                              "Telefon numarasına göre arama yapmak için: (2)");
            int searchChoice = Convert.ToInt32(Console.ReadLine());
            bool findSearch = false;
            if (searchChoice == 1)
            {
                Console.Write("Aramak istediginiz kisinin adini ya da soyadini giriniz : ");
                tempInfo = Console.ReadLine();
                List<Person> persons = personList.Where(x => (x.Name == tempInfo) || (x.Surname == tempInfo) ).ToList();

                if (persons.Count == 0)
                    Console.WriteLine("Arama başarısız.. Sonuç Bulunamadı.");
                else
                    foreach (Person person in persons)
                    {
                        personInfo(person);
                        if (persons.IndexOf(person) + 1 != personList.Count)
                            Console.WriteLine("-");
                    }     
            }
            else if (searchChoice == 2)
            {
                Console.Write("Aramak istediginiz kisinin telefon numarasini giriniz : ");
                tempInfo = Console.ReadLine();
                foreach (Person person in personList)
                {
                    if (person.TelephoneNumber.Equals(tempInfo))
                    {
                        personInfo(person);
                        findSearch = false;
                    }
                }
                if (findSearch)
                    Console.WriteLine("Arama başarısız.. Sonuç Bulunamadı.");
            }
            else
                Console.WriteLine("1 veya 2 rakamlarindan birini seciniz..");
        }

        static void personInfo(Person person)
        {
            Console.ForegroundColor =  ConsoleColor.Yellow;
            Console.WriteLine($"Isim    : {person.Name}");
            Console.WriteLine($"Soyisim : {person.Surname}");
            Console.WriteLine($"Tel No  : {person.TelephoneNumber}");
            Console.ResetColor();
        }
    }
}
