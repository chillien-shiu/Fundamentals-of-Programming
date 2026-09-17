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

        Console.WriteLine($"Chuỗi sau khi xóa trùng: {XoaTrungLap(s)}");
    }

    public static string XoaTrungLap(string s)
    {
        string result = "";
        foreach (char c in s)
        {
            if (!result.Contains(c))
            {
                result += c;
            }
        }
        return result;
    }
}