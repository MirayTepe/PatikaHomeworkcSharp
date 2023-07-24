public class TriangleDrawer
{
    public static void DrawTriangle(int size)
    {
        if (size <= 0)
            throw new ArgumentException("Size should be a positive integer.", nameof(size));

        for (int i = 1; i <= size; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}
