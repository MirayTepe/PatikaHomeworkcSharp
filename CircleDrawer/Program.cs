using System;

public class Program
{
    public static void Main()
    {
        try
        {
            Console.WriteLine("Enter the radius of the circle:");
            int radius = Convert.ToInt32(Console.ReadLine());

            CircleDrawer.DrawCircle(radius);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}

