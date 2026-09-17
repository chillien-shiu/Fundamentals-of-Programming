using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.Write("Nhập a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Nhập b: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Nhập c: ");
        int c = int.Parse(Console.ReadLine());

        Console.WriteLine($"Số lớn nhất là: {TimMax(a, b, c)}");
    }

    public static int TimMax(int a, int b, int c)
    {
        return Math.Max(Math.Max(a, b), c);
    }
}