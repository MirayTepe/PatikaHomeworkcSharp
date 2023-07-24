using System;
using System.Collections.Generic;
using ToDoApplication;





public class Program
{
    static void Main()
    {
        List<Card> board = new List<Card>
        {
            new Card { Title = "Sample Card 1", Content = "Content of Card 1", AssignedTo = 1, Size = CardSize.S, Line = "TODO" },
            new Card { Title = "Sample Card 2", Content = "Content of Card 2", AssignedTo = 2, Size = CardSize.M, Line = "IN PROGRESS" },
            new Card { Title = "Sample Card 3", Content = "Content of Card 3", AssignedTo = 3, Size = CardSize.L, Line = "DONE" }
        };

        List<TeamMember> teamMembers = new List<TeamMember>
        {
            new TeamMember { ID = 1, Name = "John" },
            new TeamMember { ID = 2, Name = "Alice" },
            new TeamMember { ID = 3, Name = "Bob" }
        };

        while (true)
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz:");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Board Listelemek");
            Console.WriteLine("(2) Board'a Kart Eklemek");
            Console.WriteLine("(3) Board'dan Kart Silmek");
            Console.WriteLine("(4) Kart Taşımak");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CardManager.ListBoard(board);
                    break;
                case "2":
                    CardManager.AddCard(board, teamMembers);
                    break;
                case "3":
                   CardManager.RemoveCard(board);
                    break;
                case "4":
                    BoardManager.MoveCard(board);
                    break;
                default:
                    Console.WriteLine("Hatalı bir seçim yaptınız!");
                    break;
            }

            Console.WriteLine();
        }
    }
}

   

    

    


