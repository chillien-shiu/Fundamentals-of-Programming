using System;

class Program
{
    public static bool IsPerfectNumber(int number)
    {
        if (number <= 1) return false;

        int sum = 1; // 1 luôn là ước của số > 1
        for (int i = 2; i <= number / 2; i++)
        {
            if (number % i == 0)
            {
                sum += i;
            }
        }
        return sum == number;
    }

    public static void PrintPerfectNumbersLessThan1000()
    {
        Console.WriteLine("Các số hoàn hảo nhỏ hơn 1000:");
        for (int i = 1; i < 1000; i++)
        {
            if (IsPerfectNumber(i))
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();
    }
}