using System;
using System.Collections.Generic;
namespace SumOFIntegerPair
{
    public class Program
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("N tane integer ikilisi girin (örn. '2 3 1 5 2 5 3 3'):");
                string input = Console.ReadLine();
                string[] numbers = input.Split(' ');

                if (numbers.Length % 2 != 0)
                {
                    throw new ArgumentException("Girilen ikililerin sayısı çift olmalıdır.");
                }

                List<int> sums = new List<int>();

                for (int i = 0; i < numbers.Length; i += 2)
                {
                    if (int.TryParse(numbers[i], out int firstNumber) && int.TryParse(numbers[i + 1], out int secondNumber))
                    {
                        int sum = firstNumber + secondNumber;
                        sums.Add(sum);
                    }
                    else
                    {
                        throw new ArgumentException("Geçersiz integer ikilisi.");
                    }
                }

                Console.WriteLine("Output:");

                for (int i = 0; i < sums.Count; i++)
                {
                    int firstNumber = int.Parse(numbers[i * 2]);
                    int secondNumber = int.Parse(numbers[i * 2 + 1]);

                    if (firstNumber == secondNumber)
                    {
                        Console.Write(sums[i] * sums[i]);
                    }
                    else
                    {
                        Console.Write(sums[i]);
                    }

                    if (i < sums.Count - 1)
                    {
                        Console.Write(" ");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }

}
