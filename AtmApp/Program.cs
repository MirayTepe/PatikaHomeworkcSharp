using System;
using System.Collections.Generic;
using System.IO;

namespace AtmApp
{
    class Program
    {
        static string usersFilePath = "users.txt";
        static string transactionsFilePath = "transactions.txt";

        static Dictionary<int, string> users = new Dictionary<int, string>();
        static List<string> transactions = new List<string>();

        static void Main()
        {
            LoadUsers();
            ShowWelcomeScreen();

            int userId;
            if (AuthenticateUser(out userId))
            {
                while (true)
                {
                    ShowMainMenu();

                    int option;
                    if (int.TryParse(Console.ReadLine(), out option))
                    {
                        switch (option)
                        {
                            case 1:
                                WithdrawMoney(userId);
                                break;
                            case 2:
                                DepositMoney(userId);
                                break;
                            case 3:
                                MakePayment(userId);
                                break;
                            case 4:
                                ShowTransactions();
                                break;
                            case 5:
                                EndOfDay();
                                return;
                            default:
                                Console.WriteLine("Geçersiz seçenek!");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz seçenek!");
                    }
                }
            }
            else
            {
                Console.WriteLine("Giriş başarısız. Geçerli bir kullanıcı ID girin.");
            }
        }

        static void LoadUsers()
        {
            if (File.Exists(usersFilePath))
            {
                string[] lines = File.ReadAllLines(usersFilePath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(';');
                    if (parts.Length == 2 && int.TryParse(parts[0], out int userId))
                    {
                        users[userId] = parts[1];
                    }
                }
            }
        }

        static bool AuthenticateUser(out int userId)
        {
            Console.Write("Kullanıcı ID girin: ");
            if (int.TryParse(Console.ReadLine(), out userId))
            {
                return users.ContainsKey(userId);
            }
            return false;
        }

        static void ShowWelcomeScreen()
        {
            Console.WriteLine("Bankamıza hoş geldiniz!");
            Console.WriteLine("-----------------------");
        }

        static void ShowMainMenu()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçin:");
            Console.WriteLine("1 - Para Çekme");
            Console.WriteLine("2 - Para Yatırma");
            Console.WriteLine("3 - Ödeme Yapma");
            Console.WriteLine("4 - İşlem Geçmişi");
            Console.WriteLine("5 - Gün Sonu");
        }

        static void LogTransaction(string transaction)
        {
            transactions.Add(transaction);
        }

        static void WithdrawMoney(int userId)
        {
            Console.Write("Çekmek istediğiniz tutarı girin: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal amount) && amount > 0)
            {
                // Burada hesaptan para çekme işlemlerini gerçekleştirebilirir.
                LogTransaction($"{DateTime.Now} - Kullanıcı {userId} tarafından {amount} TL para çekildi.");
                Console.WriteLine($"{amount} TL çekildi.");
            }
            else
            {
                Console.WriteLine("Geçersiz tutar!");
            }
        }

        static void DepositMoney(int userId)
        {
            Console.Write("Yatırmak istediğiniz tutarı girin: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal amount) && amount > 0)
            {
                // Burada hesaba para yatırma işlemlerini gerçekleştirir.
                LogTransaction($"{DateTime.Now} - Kullanıcı {userId} tarafından {amount} TL para yatırıldı.");
                Console.WriteLine($"{amount} TL yatırıldı.");
            }
            else
            {
                Console.WriteLine("Geçersiz tutar!");
            }
        }

        static void MakePayment(int userId)
        {
            Console.Write("Ödemek istediğiniz tutarı girin: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal amount) && amount > 0)
            {
                // Burada ödeme işlemlerini gerçekleştirebilirir.
                LogTransaction($"{DateTime.Now} - Kullanıcı {userId} tarafından {amount} TL ödeme yapıldı.");
                Console.WriteLine($"{amount} TL ödeme yapıldı.");
            }
            else
            {
                Console.WriteLine("Geçersiz tutar!");
            }
        }

        static void ShowTransactions()
        {
            Console.WriteLine("İşlem Geçmişi:");
            foreach (string transaction in transactions)
            {
                Console.WriteLine(transaction);
            }
        }

        static void EndOfDay()
        {
            Console.WriteLine("Gün sonu alınıyor...");

            // Gün sonu işlemleri burada yapılır. Örneğin, transactions listesini bir dosyaya yazabilirsiniz.
            File.WriteAllLines(transactionsFilePath, transactions);

            Console.WriteLine("Gün sonu işlemi tamamlandı.");
        }
    }
}