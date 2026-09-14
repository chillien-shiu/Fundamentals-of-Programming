using System;
using System.Linq;

class Program
{
    public static int FindMaxOfThree(int a, int b, int c)
    {
        return Math.Max(a, Math.Max(b, c));
    }

    public static int FindMax(int firstNumber, params int[] otherNumbers)
    {
        int max = firstNumber;
        foreach (int num in otherNumbers)
        {
            if (num > max) max = num;
        }
        return max;
    }
}