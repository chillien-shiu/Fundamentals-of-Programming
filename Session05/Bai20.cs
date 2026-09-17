using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.Write("Nhập câu: ");
        string sentence = Console.ReadLine();

        Console.WriteLine($"Số từ trong câu: {DemSoTu(sentence)}");
    }

    public static int DemSoTu(string sentence)
    {
        if (string.IsNullOrWhiteSpace(sentence)) return 0;
        string[] words = sentence.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }
}