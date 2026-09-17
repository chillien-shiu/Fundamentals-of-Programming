using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.Write("Nhập số thứ nhất: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Nhập số thứ hai: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine($"Tổng hai số là: {TinhTong(a, b)}");
    }

    public static int TinhTong(int a, int b)
    {
        return a + b;
    }
}