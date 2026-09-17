using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.Write("Nhập số lượng n: ");
        int n = int.Parse(Console.ReadLine());

        InFibonacci(n);
    }

    public static void InFibonacci(int n)
    {
        int a = 0, b = 1;
        for (int i = 0; i < n; i++)
        {
            Console.Write(a + " ");
            int temp = a + b;
            a = b;
            b = temp;
        }
        Console.WriteLine();
    }
}