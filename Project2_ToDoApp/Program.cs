using System;
using System.Collections.Generic;

namespace Project2_ToDoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> team = new Dictionary<int, string>()
            {
                {1, "A Team"}, {2, "B Team"}, {3, "C Team" }
            };

            Board board = new Board();
            board.Done = new List<Card>();
            board.TodoLine = new List<Card>()
            {
                new Card(){Title="As", Content="asddasf", AssignedPerson=1, Size=CardSize.XS, Line = CardLine.TODO_Line},
                new Card(){Title="DS", Content="faafada", AssignedPerson=3, Size=CardSize.M, Line = CardLine.TODO_Line},
            };
            board.InProgress = new List<Card>()
            {
                new Card(){Title="inProg", Content="inaeos", AssignedPerson=2, Size=CardSize.L, Line = CardLine.InProgress_Line }
            };

            do
            {
                Console.WriteLine("\nLütfen yapmak istediğiniz işlemi seçiniz : ");
                Console.WriteLine("*******************************************");
                Console.WriteLine("(1) Board Listelemek");
                Console.WriteLine("(2) Board'a Kart Eklemek");
                Console.WriteLine("(3) Board'dan Kart Silmek");
                Console.WriteLine("(4) Kart Taşımak");
                Console.Write("Seciminiz = ");
                int secim = Convert.ToInt32(Console.ReadLine());
                string[] boardTitle = { "TODO Line", "IN PROGRESS Line", "DONE Line" };
                List<List<Card>> boardList = new List<List<Card>>()
            {
                board.TodoLine, board.InProgress, board.Done
            };
                bool isCard = false;
                int boardChoice = 0;
                switch (secim)
                {
                    case 1:
                        for (int i = 0; i < 3; i++)
                        {
                            Console.WriteLine(boardTitle[i]);
                            Console.WriteLine("*************************");
                            if (boardList[i].Count != 0)
                                foreach (Card card in boardList[i])
                                {
                                    Console.WriteLine($"Baslik      = {card.Title}");
                                    Console.WriteLine($"Icerik      = {card.Content}");
                                    Console.WriteLine($"Atanan Kisi = {team[card.AssignedPerson]}");
                                    Console.WriteLine($"Buyukluk    = {card.Size}");
                                    if (boardList[i].IndexOf(card) + 1 != boardList[i].Count)
                                        Console.WriteLine("-");
                                    else
                                        Console.WriteLine("\n");
                                }
                            else
                                Console.WriteLine("~ EMPTY ~\n");
                        }
                        break;

                    case 2:
                        Card newCard = new Card();
                        Console.Write("Baslik Giriniz".PadRight(48) + ": ");
                        newCard.Title = Console.ReadLine();
                        Console.Write("İcerik Giriniz".PadRight(48) + ": ");
                        newCard.Content = Console.ReadLine();
                        Console.Write("Buyukluk Seciniz -> XS(1),S(2),M(3),L(4),XL(5)".PadRight(48) + ": ");
                        newCard.Size = (CardSize)Convert.ToInt32(Console.ReadLine());
                        Console.Write("Kisi Seciniz(ID yaziniz--ID yoksa hata ver)".PadRight(48) + ": ");
                        int teamChoice = Convert.ToInt32(Console.ReadLine());
                        if (team.ContainsKey(teamChoice))
                        {
                            newCard.AssignedPerson = teamChoice;
                            Console.WriteLine("(1) TODO\n" +
                                              "(2) IN PROGRESS\n" +
                                              "(3) DONE");
                            boardChoice = Convert.ToInt32(Console.ReadLine());
                            newCard.Line = (CardLine)(boardChoice - 1);
                            boardList[boardChoice - 1].Add(newCard);
                            Console.WriteLine("Kart Eklendi");
                        }
                        else
                            Console.WriteLine("Sectiginiz kisi yok. Kart olusturulamadi.");
                        break;

                    case 3:
                        int deleteChoice = 0;
                        do
                        {
                            deleteChoice = 0;
                            Console.WriteLine("Oncelikle silmek istediginiz karti secmeniz gerekmektedir.");
                            Console.Write("Lutfen kart basligini yaziniz: ");
                            string cardTitle = Console.ReadLine();
                            for (int i = 0; i < 3; i++)
                            {
                                if (boardList[i].Count != 0)
                                    foreach (Card card in boardList[i])
                                    {
                                        if (card.Title.Equals(cardTitle))
                                        {
                                            isCard = true;
                                            boardList[i].Remove(card);
                                            Console.WriteLine("Kart bulundu. Silme gerceklesti. ");
                                            break;
                                        }
                                    }
                                if (isCard)
                                    break;
                            }
                            if (!isCard)
                            {
                                Console.Write("Aradiginiz kriterlere uygun kart board 'da bulunamadi. Lutfen Secim yapiniz.\n" +
                                              "* Silmeyi sonlandirmak icin : (1)\n" +
                                              "* Yeniden denemek icin : (2)\n" +
                                              "Seciminiz : ");
                                deleteChoice = Convert.ToInt32(Console.ReadLine());
                            }
                        } while(deleteChoice == 2);
                        break;

                    case 4:
                        int transportChoice = 0;
                        do
                        {
                            transportChoice = 0;
                            Console.WriteLine("Oncelikle Tasimak istediginiz karti secmeniz gerekmektedir.");
                            Console.Write("Lutfen kart basligini yaziniz: ");
                            string cardTitle = Console.ReadLine();
                            for (int i = 0; i < 3; i++)
                            {
                                if (boardList[i].Count != 0)
                                    foreach (Card card in boardList[i])
                                    {
                                        if (card.Title.Equals(cardTitle))
                                        {
                                            Console.WriteLine("Bulunan Kart Bilgileri");
                                            Console.WriteLine("************************");
                                            Console.WriteLine($"Baslik      : {card.Title}\n" +
                                                              $"İcerik      : {card.Content}\n" +
                                                              $"Atanan Kisi : {card.AssignedPerson}\n" +
                                                              $"Buyukluk    : {card.Size}\n" +
                                                              $"Line        : {card.Line}\n");
                                            isCard = true;
                                            Console.WriteLine("\nLutfen tasimak istediginiz Line 'i seciniz:\n" +
                                                              "(1) TODO\n" +
                                                              "(2) IN PROGRESS\n" +
                                                              "(3) DONE");

                                            boardList[(int)card.Line].Remove(card);
                                            boardChoice = Convert.ToInt32(Console.ReadLine());
                                            card.Line = (CardLine)(boardChoice-1);
                                            boardList[(int)card.Line].Add(card);
                                            break;
                                        }
                                    }
                                if (isCard)
                                    break;
                            }
                            if (!isCard)
                            {
                                Console.Write("Aradiginiz kriterlere uygun kart board 'da bulunamadi. Lutfen Secim yapiniz.\n" +
                                              "* İslemi sonlandirmak icin : (1)\n" +
                                              "* Yeniden denemek icin : (2)\n" +
                                              "Seciminiz : ");
                                transportChoice = Convert.ToInt32(Console.ReadLine());
                            }
                        } while (transportChoice == 2);
                        break;
                    default:
                        Console.WriteLine("1-4 arasi secim yapiniz");
                        break;
                }

            } while (true);


        }
    }
}
