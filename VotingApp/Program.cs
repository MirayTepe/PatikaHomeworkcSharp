using System;
using System.Collections.Generic;

namespace VotingApp
{
    class Program
    {
        static Dictionary<string, int> categoryVotes = new Dictionary<string, int>();
        static Dictionary<string, string> users = new Dictionary<string, string>();

        static void Main()
        {
            // Kategorileri pre-defined olarak belirleyelim
            string[] categories = { "Film Kategorileri", "Tech Stack Kategorileri", "Spor Kategorileri" };

            // Sistemde kayıtlı kullanıcılar
            users["user1"] = "password1";
            users["user2"] = "password2";
         

            Console.WriteLine("Voting Uygulamasına Hoş Geldiniz!");
            Console.WriteLine("Lütfen kullanıcı adınızı girin:");
            string username = Console.ReadLine();

            // Eğer kullanıcı kayıtlı değilse kayıt olma işlemi yapalım
            if (!users.ContainsKey(username))
            {
                Console.WriteLine("Kullanıcı kayıtlı değil. Lütfen şifrenizi belirleyin:");
                string password = Console.ReadLine();
                users[username] = password;
                Console.WriteLine("Kayıt işlemi tamamlandı. Oylamaya devam edebilirsiniz.");
            }

            while (true)
            {
                Console.WriteLine("Oylamak istediğiniz kategoriyi seçin:");

                for (int i = 0; i < categories.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {categories[i]}");
                }

                Console.WriteLine($"{categories.Length + 1}. Çıkış yap");

                if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 1 && choice <= categories.Length)
                {
                    string selectedCategory = categories[choice - 1];
                    Vote(selectedCategory);
                }
                else if (choice == categories.Length + 1)
                {
                    Console.WriteLine("Oylama sonlandırılıyor...");
                    ShowResults();
                    break;
                }
                else
                {
                    Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
                }
            }
        }

        static void Vote(string category)
        {
            if (categoryVotes.ContainsKey(category))
            {
                categoryVotes[category]++;
            }
            else
            {
                categoryVotes[category] = 1;
            }

            Console.WriteLine($"Kategori \"{category}\" için oy verildi.");
        }

        static void ShowResults()
        {
            Console.WriteLine("Voting Sonuçları:");

            int totalVotes = 0;
            foreach (var kvp in categoryVotes)
            {
                totalVotes += kvp.Value;
            }

            foreach (var kvp in categoryVotes)
            {
                string category = kvp.Key;
                int votes = kvp.Value;
                double percentage = (double)votes / totalVotes * 100;
                Console.WriteLine($"{category}: {votes} oy - %{percentage:F2}");
            }
        }
    }

}


