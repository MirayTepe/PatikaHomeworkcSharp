using System;
namespace AbsoluteSquare
{
    class Program
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("N tane sayı girin (örn. '56 45 68 77'):");
                string input = Console.ReadLine();
                string[] numbers = input.Split(' ');

                int sumLessThan67 = 0;
                int sumGreaterThan67 = 0;

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (int.TryParse(numbers[i], out int number))
                    {
                        if (number < 67)
                        {
                            sumLessThan67 += 67 - number;
                        }
                        else
                        {
                            sumGreaterThan67 += (number - 67) * (number - 67);
                        }
                    }
                    else
                    {
                        throw new ArgumentException("Geçersiz sayı girişi.");
                    }
                }

                Console.WriteLine($"Output: {sumLessThan67} {sumGreaterThan67}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }

}
