using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.Write("Nhập số thập phân n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"Mã nhị phân: {DecimalToBinary(n)}");
    }

    public static string DecimalToBinary(int n)
    {
        if (n == 0) return "0";
        string binary = "";
        while (n > 0)
        {
            binary = (n % 2) + binary;
            n /= 2;
        }
        return binary;
    }
}