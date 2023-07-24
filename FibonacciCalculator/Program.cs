using System;

public class Program
{
    public static void Main()
    {
        try
        {
            Console.WriteLine("Enter the depth of the Fibonacci series:");
            int depth = Convert.ToInt32(Console.ReadLine());

            double average = AverageCalculator.CalculateAverage(depth);
            Console.WriteLine($"Average of Fibonacci series up to depth {depth}: {average}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
