using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.Write("Nhập năm: ");
        int year = int.Parse(Console.ReadLine());

        Console.WriteLine($"KiemTraNamNhuan({year}) -> {KiemTraNamNhuan(year)}");
    }

    public static bool KiemTraNamNhuan(int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }
}