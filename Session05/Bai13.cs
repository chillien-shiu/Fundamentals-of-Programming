using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.Write("Nhập số phần tử của mảng: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"arr[{i}] = ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine($"Giá trị nhỏ nhất: {TimMin(arr)}");
    }

    public static int TimMin(int[] arr)
    {
        int min = arr[0];
        foreach (int num in arr)
        {
            if (num < min) min = num;
        }
        return min;
    }
}