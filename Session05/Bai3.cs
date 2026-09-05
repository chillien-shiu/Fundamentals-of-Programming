using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("PHÂN LOẠI TAM GIÁC");

        Console.Write("Nhập độ dài cạnh thứ 1: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Nhập độ dài cạnh thứ 2: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Nhập độ dài cạnh thứ 3: ");
        double c = double.Parse(Console.ReadLine());
        if (a + b > c && a + c > b && b + c > a)
        {
            if (a == b && b == c)
            {
                Console.WriteLine("Đây là Tam giác đều.");
            }
            else if (a == b || a == c || b == c)
            {
                Console.WriteLine("Đây là Tam giác cân.");
            }
            else
            {
                Console.WriteLine("Đây là Tam giác thường (Scalene).");
            }
        }
        else
        {
            Console.WriteLine("Ba độ dài trên không tạo thành một tam giác hợp lệ.");
        }
    }
}