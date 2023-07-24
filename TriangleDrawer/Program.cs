using System;

public class Program
{
    public static void Main()
    {
        try
        {
            Console.WriteLine("Enter the size of the triangle:");
            int size = Convert.ToInt32(Console.ReadLine());

            TriangleDrawer.DrawTriangle(size);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
