using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("XÁC ĐỊNH GÓC PHẦN TƯ CỦA TỌA ĐỘ");

        Console.Write("Nhập giá trị hoành độ X: ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Nhập giá trị tung độ Y: ");
        int y = int.Parse(Console.ReadLine());

        if (x > 0 && y > 0)
        {
            Console.WriteLine($"Điểm tọa độ ({x},{y}) nằm ở Góc phần tư thứ nhất (Góc I).");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine($"Điểm tọa độ ({x},{y}) nằm ở Góc phần tư thứ hai (Góc II).");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine($"Điểm tọa độ ({x},{y}) nằm ở Góc phần tư thứ ba (Góc III).");
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine($"Điểm tọa độ ({x},{y}) nằm ở Góc phần tư thứ tư (Góc IV).");
        }
        else if (x == 0 && y == 0)
        {
            Console.WriteLine($"Điểm tọa độ ({x},{y}) trùng với Gốc tọa độ O.");
        }
        else if (x == 0)
        {
            Console.WriteLine($"Điểm tọa độ ({x},{y}) nằm trên trục tung Oy.");
        }
        else
        {
            Console.WriteLine($"Điểm tọa độ ({x},{y}) nằm trên trục hoành Ox.");
        }
    }
}