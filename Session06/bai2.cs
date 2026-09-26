using System;
using System.Collections.Generic;
using System.Text;

class Part2
{
    public static void BubbleSortDemo()
    {
        int[] numbers = new int[10];
        Console.WriteLine("Nhập 10 số nguyên:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Số thứ {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            for (int j = 0; j < numbers.Length - 1 - i; j++)
            {
                if (numbers[j] > numbers[j + 1])
                {
                    // Đổi chỗ
                    int temp = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("\nMảng sau khi sắp xếp (Bubble Sort):");
        Console.WriteLine(string.Join(", ", numbers));
    }

    public static void LinearSearchWordDemo()
    {
        Console.Write("\nNhập một câu văn: ");
        string sentence = Console.ReadLine();

        Console.Write("Nhập từ cần tìm: ");
        string wordToFind = Console.ReadLine();

        string[] words = sentence.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        bool found = false;
        int position = -1;

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Equals(wordToFind, StringComparison.OrdinalIgnoreCase))
            {
                found = true;
                position = i;
                break;
            }
        }

        if (found)
        {
            Console.WriteLine($"Từ '{wordToFind}' xuất hiện trong câu tại vị trí từ số {position + 1}.");
        }
        else
        {
            Console.WriteLine($"Từ '{wordToFind}' KHÔNG xuất hiện trong câu.");
        }
    }
}