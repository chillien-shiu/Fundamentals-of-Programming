using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("TÌM SỐ LỚN NHẤT TRONG 3 SỐ");

        Console.Write("Nhập số thứ nhất: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Nhập số thứ hai: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Nhập số thứ ba: ");
        int c = int.Parse(Console.ReadLine());

        int max = a;
        if (b > max) max = b;
        if (c > max) max = c;

        Console.WriteLine($"Số lớn nhất trong 3 số là: {max}");
    }
}