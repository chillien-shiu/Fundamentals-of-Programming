using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.Write("Nhập số a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Nhập số b: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine($"UCLN({a}, {b}) = {UCLN(a, b)}");
    }

    public static int UCLN(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return Math.Abs(a);
    }
}