namespace StringManipulator2
{
    public class StringManipulator
    {
        public static string SwapCharactersWithPrevious(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentException("Invalid input. Please provide a non-empty string.");
            }

            char[] characters = str.ToCharArray();
            for (int i = 1; i < characters.Length; i++)
            {
                char temp = characters[i];
                characters[i] = characters[i - 1];
                characters[i - 1] = temp;
            }

            return new string(characters);
        }
    }
}