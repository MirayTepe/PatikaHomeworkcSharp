using System;
namespace CharacterChange
{
    class Program
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("String ifade girin:");
                string input = Console.ReadLine();

                if (!string.IsNullOrEmpty(input))
                {
                    char firstChar = input[0];
                    char lastChar = input[input.Length - 1];

                    char[] charArray = input.ToCharArray();
                    charArray[0] = lastChar;
                    charArray[charArray.Length - 1] = firstChar;

                    string output = new string(charArray);
                    Console.WriteLine($"Output: {output}");
                }
                else
                {
                    throw new ArgumentException("Boş bir ifade girdiniz.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }

}

