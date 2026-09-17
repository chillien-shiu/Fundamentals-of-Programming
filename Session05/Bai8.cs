using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.Write("Nhập chuỗi: ");
        string s = Console.ReadLine();

        Console.WriteLine($"Số nguyên âm: {DemNguyenAm(s)}");
    }

    public static int DemNguyenAm(string s)
    {
        int count = 0;
        string vowels = "aeiouAEIOU";
        foreach (char c in s)
        {
            if (vowels.Contains(c)) count++;
        }
        return count;
    }
}