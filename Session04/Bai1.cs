using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("KIỂM TRA SỐ CHẴN HAY SỐ LẺ");

        Console.Write("Nhập vào một số nguyên: ");
        int n = int.Parse(Console.ReadLine());

        if (n % 2 == 0)
        {
            Console.WriteLine($"{n} là số chẵn.");
        }
        else
        {
            Console.WriteLine($"{n} là số lẻ.");
        }
    }
}