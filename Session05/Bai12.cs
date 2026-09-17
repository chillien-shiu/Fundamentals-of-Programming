using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.Write("Nhập độ C: ");
        double c = double.Parse(Console.ReadLine());

        Console.WriteLine($"{c}°C = {CelsiusToFahrenheit(c)}°F");
    }

    public static double CelsiusToFahrenheit(double c)
    {
        return (c * 9 / 5) + 32;
    }
}