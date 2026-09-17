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

        Console.WriteLine($"{n}! = {TinhGiaiThua(n)}");
    }

    public static long TinhGiaiThua(int n)
    {
        long result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }
}