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

        Console.WriteLine($"Trung bình cộng = {TinhTrungBinh(arr)}");
    }

    public static double TinhTrungBinh(int[] arr)
    {
        if (arr.Length == 0) return 0;
        int sum = 0;
        foreach (int num in arr)
        {
            sum += num;
        }
        return (double)sum / arr.Length;
    }
}