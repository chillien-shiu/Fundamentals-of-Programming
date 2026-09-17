using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.Write("Nhập số n: ");
        int n = int.Parse(Console.ReadLine());

        if (KiemTraChan(n))
            Console.WriteLine($"{n} là số chẵn.");
        else
            Console.WriteLine($"{n} là số lẻ.");
    }

    public static bool KiemTraChan(int n)
    {
        return n % 2 == 0;
    }
}