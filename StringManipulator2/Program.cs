using System;

namespace StringManipulator2
{

    public class Program
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("Enter a string:");
                string input = Console.ReadLine();

                string result = StringManipulator.SwapCharactersWithPrevious(input);
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}