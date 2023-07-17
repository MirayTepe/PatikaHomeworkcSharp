using System;
namespace Array_Questions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1- Çift Sayıları Bulma");
            Console.WriteLine("2- Tam Bölünenleri Bulma");
            Console.WriteLine("3- Kelimeleri Sondan Başa Yazdırma");
            Console.WriteLine("4- Kelime ve Harf Sayısını Bulma");

            Console.Write("Lütfen bir işlem seçin (1-4): ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    FindEvenNumbers();
                    break;
                case 2:
                    FindMultiples();
                    break;
                case 3:
                    ReverseWords();
                    break;
                case 4:
                    CountWordsAndLetters();
                    break;
                default:
                    Console.WriteLine("Geçersiz bir seçim yaptınız.");
                    break;
            }

            Console.WriteLine("Programdan çıkmak için herhangi bir tuşa basın.");
            Console.ReadKey();

        }

        static void FindEvenNumbers()
        {
            Console.Write("Pozitif bir sayı girin: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"{n} adet pozitif sayı girin:");

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    Console.WriteLine(num);
                }
            }
        }

        static void FindMultiples()
        {
            Console.Write("Pozitif bir sayı girin (n): ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Pozitif bir sayı daha girin (m): ");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine($"{n} adet pozitif sayı girin:");

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num % m == 0 || num == m)
                {
                    Console.WriteLine(num);
                }
            }
        }

        static void ReverseWords()
        {
            Console.Write("Pozitif bir sayı girin: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"{n} adet kelime girin:");

            string[] words = new string[n];

            for (int i = 0; i < n; i++)
            {
                words[i] = Console.ReadLine();
            }

            Console.WriteLine("Girilen kelimelerin sondan başa doğru sıralanması:");

            for (int i = n - 1; i >= 0; i--)
            {
                Console.WriteLine(words[i]);
            }
        }

        static void CountWordsAndLetters()
        {
            Console.Write("Bir cümle girin: ");
            string sentence = Console.ReadLine();

            string[] words = sentence.Split(' ');

            int wordCount = words.Length;
            int letterCount = 0;

            foreach (string word in words)
            {
                letterCount += word.Length;
            }

            Console.WriteLine($"Cümledeki kelime sayısı: {wordCount}");
            Console.WriteLine($"Cümledeki harf sayısı: {letterCount}");
        }
    }
}

