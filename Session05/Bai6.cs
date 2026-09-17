using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.Write("Nhập n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"KiemTraNguyenTo({n}) -> {KiemTraNguyenTo(n)}");
    }

    public static bool KiemTraNguyenTo(int n)
    {
        if (n <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }
}