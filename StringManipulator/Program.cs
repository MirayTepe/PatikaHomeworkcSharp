using System;

public class Program
{
    public static void Main()
    {
        try
        {
            Console.WriteLine("Enter a string and an index (separated by comma):");
            string input = Console.ReadLine();

            string[] parts = input.Split(',');
            if (parts.Length == 2 && int.TryParse(parts[1], out int index))
            {
                string str = parts[0].Trim();
                StringManipulator.RemoveCharacterAtIndex(str, index);
            }
            else
            {
                throw new ArgumentException("Invalid input format. Please provide string and index separated by a comma.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
