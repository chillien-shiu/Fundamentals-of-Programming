using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Giải phương trình bậc 2: ax^2 + bx + c = 0");
        Console.Write("Nhập a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Nhập b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Nhập c: ");
        double c = double.Parse(Console.ReadLine());

        if (a == 0)
        {
            if (b == 0)
            {
                if (c == 0)
                    Console.WriteLine("Phương trình có vô số nghiệm.");
                else
                    Console.WriteLine("Phương trình vô nghiệm.");
            }
            else
            {
                double x = -c / b;
                Console.WriteLine($"Phương trình có 1 nghiệm (bậc 1): x = {x}");
            }
        }
        else
        {
            double delta = b * b - 4 * a * c;
            if (delta < 0)
            {
                Console.WriteLine("Phương trình vô nghiệm.");
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"Phương trình có nghiệm kép: x1 = x2 = {x}");
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"Phương trình có 2 nghiệm phân biệt:\n x1 = {x1}\n x2 = {x2}");
            }
        }
    }
}