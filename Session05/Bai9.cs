using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.Write("Nhập cơ số x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Nhập số mũ y: ");
        int y = int.Parse(Console.ReadLine());

        Console.WriteLine($"Kết quả: {TinhLuyThua(x, y)}");
    }

    public static double TinhLuyThua(double x, int y)
    {
        double result = 1;
        int exp = Math.Abs(y);
        for (int i = 0; i < exp; i++)
        {
            result *= x;
        }
        return y < 0 ? 1 / result : result;
    }
}