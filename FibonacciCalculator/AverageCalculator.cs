public class AverageCalculator
{
    public static double CalculateAverage(int depth)
    {
        if (depth <= 0)
            throw new ArgumentException("Depth should be a positive integer.", nameof(depth));

        int sum = 0;
        for (int i = 1; i <= depth; i++)
        {
            int fib = FibonacciCalculator.Fibonacci(i);
            sum += fib;
        }

        return (double)sum / depth;
    }
}
