using System;
namespace Consanant
{
    class Program
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("String ifade girin:");
                string input = Console.ReadLine();

                string[] words = input.Split(' ');

                Console.Write("Output:");

                foreach (string word in words)
                {
                    bool found = false;
                    for (int i = 0; i < word.Length - 1; i++)
                    {
                        if (IsConsonant(word[i]) && IsConsonant(word[i + 1]))
                        {
                            found = true;
                            break;
                        }
                    }

                    Console.Write($" {found}");
                }

                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public static bool IsConsonant(char ch)
        {
            char lowerCh = char.ToLower(ch);
            return lowerCh >= 'b' && lowerCh <= 'z' && lowerCh != 'e' && lowerCh != 'i' && lowerCh != 'o' && lowerCh != 'u';
        }
    }
}

