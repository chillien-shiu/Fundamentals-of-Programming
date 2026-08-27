using System;
using System.Text;

class Bai02
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.WriteLine("BẢNG GIÁ TRỊ HÀM SỐ x = y^2 + 2y + 1");
        Console.WriteLine("y\tx");
        Console.WriteLine("----------------");

        for (int y = -5; y <= 5; y++)
        {
            int x = y * y + 2 * y + 1;
            Console.WriteLine($"{y}\t{x}");
        }

        Console.WriteLine("\nBấm phím bất kỳ để thoát...");
        Console.ReadKey();
    }
}