using System;

class Program
{
    public static long Factorial(int n)
    {
        if (n < 0) throw new ArgumentException("Số phải không âm!");
        if (n == 0 || n == 1) return 1;

        long result = 1;
        for (int i = 2; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }
}