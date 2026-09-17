using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.Write("Nhập số nguyên n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"Tổng các chữ số: {TongCacChuSo(n)}");
    }

    public static int TongCacChuSo(int n)
    {
        int sum = 0;
        n = Math.Abs(n);
        while (n > 0)
        {
            sum += n % 10;
            n /= 10;
        }
        return sum;
    }
}