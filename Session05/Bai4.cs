using System;

class Program
{
    // 4.1 In tất cả các số nguyên tố nhỏ hơn N
    public static void PrintPrimesLessThan(int limit)
    {
        Console.WriteLine($"Các số nguyên tố nhỏ hơn {limit}:");
        for (int i = 2; i < limit; i++)
        {
            if (Exercise3.IsPrime(i))
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();
    }

    // 4.2 In N số nguyên tố đầu tiên
    public static void PrintFirstNPrimes(int n)
    {
        Console.WriteLine($"{n} số nguyên tố đầu tiên:");
        int count = 0;
        int number = 2;
        while (count < n)
        {
            if (Exercise3.IsPrime(number))
            {
                Console.Write(number + " ");
                count++;
            }
            number++;
        }
        Console.WriteLine();
    }
}