using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApplication
{
    public class CardManager
    {
        public static void ListBoard(List<Card> board)
        {
            Console.WriteLine("TODO Line");
            Console.WriteLine("************************");

            foreach (var card in board)
            {
                if (card.Line == "TODO")
                {
                    DisplayCardDetails(card);
                    Console.WriteLine("-");
                }
            }

            Console.WriteLine("IN PROGRESS Line");
            Console.WriteLine("************************");

            foreach (var card in board)
            {
                if (card.Line == "IN PROGRESS")
                {
                    DisplayCardDetails(card);
                    Console.WriteLine("-");
                }
            }

            Console.WriteLine("DONE Line");
            Console.WriteLine("************************");

            foreach (var card in board)
            {
                if (card.Line == "DONE")
                {
                    DisplayCardDetails(card);
                    Console.WriteLine("-");
                }
            }
        }

        public static void AddCard(List<Card> board, List<TeamMember> teamMembers)
        {
            Card newCard = new Card();

            Console.Write("Başlık Giriniz: ");
            newCard.Title = Console.ReadLine();

            Console.Write("İçerik Giriniz: ");
            newCard.Content = Console.ReadLine();

            Console.Write("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5): ");
            int sizeChoice = int.Parse(Console.ReadLine());
            newCard.Size = (CardSize)sizeChoice;

            Console.Write("Kişi Seçiniz (ID): ");
            int assignedTo = int.Parse(Console.ReadLine());

            // Check if the assigned ID is valid
            if (teamMembers.Exists(tm => tm.ID == assignedTo))
            {
                newCard.AssignedTo = assignedTo;
                newCard.Line = "TODO";
                board.Add(newCard);
            }
            else
            {
                Console.WriteLine("Hatalı giriş yaptınız! Kart eklenmedi.");
            }
        }

        public static void RemoveCard(List<Card> board)
        {
            Console.Write("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.\nLütfen kart başlığını yazınız: ");
            string cardTitle = Console.ReadLine();

            bool found = false;

            for (int i = board.Count - 1; i >= 0; i--)
            {
                if (board[i].Title == cardTitle)
                {
                    DisplayCardDetails(board[i]);
                    Console.WriteLine();

                    found = true;

                    Console.WriteLine("Kartı silmek istediğinize emin misiniz? (E/H)");
                    string confirm = Console.ReadLine();

                    if (confirm.ToUpper() == "E")
                    {
                        board.RemoveAt(i);
                        Console.WriteLine("Kart başarıyla silindi.");
                    }
                    else
                    {
                        Console.WriteLine("Kart silme işlemi iptal edildi.");
                    }
                }
            }

            if (!found)
            {
                Console.WriteLine("Aradığınız kriterlere uygun kart board'da bulunamadı.");
            }
        }
        public static void DisplayCardDetails(Card card)
        {
            Console.WriteLine($"Başlık: {card.Title}");
            Console.WriteLine($"İçerik: {card.Content}");
            Console.WriteLine($"Atanan Kişi: {card.AssignedTo}");
            Console.WriteLine($"Büyüklük: {card.Size}");
        }
    }
}
