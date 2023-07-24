using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApplication
{
    public class BoardManager
    {
        public static void MoveCard(List<Card> board)
        {
            Console.Write("Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.\nLütfen kart başlığını yazınız: ");
            string cardTitle = Console.ReadLine();

            bool found = false;

            for (int i = 0; i < board.Count; i++)
            {
                if (board[i].Title == cardTitle)
                {
                    CardManager.DisplayCardDetails(board[i]);
                    Console.WriteLine();

                    found = true;

                    Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz: (1) TODO (2) IN PROGRESS (3) DONE");
                    string lineChoice = Console.ReadLine();

                    switch (lineChoice)
                    {
                        case "1":
                            board[i].Line = "TODO";
                            Console.WriteLine("Kart başarıyla TODO Line'a taşındı.");
                            break;
                        case "2":
                            board[i].Line = "IN PROGRESS";
                            Console.WriteLine("Kart başarıyla IN PROGRESS Line'a taşındı.");
                            break;
                        case "3":
                            board[i].Line = "DONE";
                            Console.WriteLine("Kart başarıyla DONE Line'a taşındı.");
                            break;
                        default:
                            Console.WriteLine("Hatalı bir seçim yaptınız! Kart taşıma işlemi iptal edildi.");
                            break;
                    }
                }
            }

            if (!found)
            {
                Console.WriteLine("Aradığınız kriterlere uygun kart board'da bulunamadı.");
            }
        }

    }
}
