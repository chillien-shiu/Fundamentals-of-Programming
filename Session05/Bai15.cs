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

        Console.Write("Mảng sau khi sắp xếp: ");
        SapXepMang(arr);
    }

    public static void SapXepMang(int[] arr)
    {
        Array.Sort(arr);
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}