public class StringManipulator
{
    public static void RemoveCharacterAtIndex(string str, int index)
    {
        if (string.IsNullOrEmpty(str) || index < 0 || index >= str.Length)
        {
            throw new ArgumentException("Invalid input. Please provide a valid string and index.");
        }

        string result = str.Remove(index, 1);
        Console.WriteLine(result);
    }
}
