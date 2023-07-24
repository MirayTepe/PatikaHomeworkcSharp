public class FibonacciCalculator
{
    public static int Fibonacci(int n)
    {
        if (n <= 0)
            throw new ArgumentException("N should be a positive integer.", nameof(n));

        if (n == 1 || n == 2)
            return 1;

        int prev = 1;
        int current = 1;

        for (int i = 3; i <= n; i++)
        {
            int next = prev + current;
            prev = current;
            current = next;
        }

        return current;
    }
}
