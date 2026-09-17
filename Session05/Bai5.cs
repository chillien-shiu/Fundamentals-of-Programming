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

        Console.WriteLine($"Chuỗi đảo ngược: {DaoNguocChuoi(s)}");
    }

    public static string DaoNguocChuoi(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}