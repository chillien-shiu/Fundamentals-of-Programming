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

        Console.WriteLine($"KiemTraDoiXung(\"{s}\") -> {KiemTraDoiXung(s)}");
    }

    public static bool KiemTraDoiXung(string s)
    {
        int left = 0;
        int right = s.Length - 1;
        while (left < right)
        {
            if (s[left] != s[right]) return false;
            left++;
            right--;
        }
        return true;
    }
}