public class CircleDrawer
{
    public static void DrawCircle(int radius)
    {
        if (radius <= 0)
            throw new ArgumentException("Radius should be a positive integer.", nameof(radius));

        int diameter = 2 * radius;
        int centerX = radius;
        int centerY = radius;

        for (int y = 0; y <= diameter; y++)
        {
            for (int x = 0; x <= diameter; x++)
            {
                double distance = Math.Sqrt(Math.Pow(x - centerX, 2) + Math.Pow(y - centerY, 2));

                if (Math.Abs(distance - radius) < 0.5)
                {
                    Console.Write("* ");
                }
                else
                {
                    Console.Write("  ");
                }
            }
            Console.WriteLine();
        }
    }
}

