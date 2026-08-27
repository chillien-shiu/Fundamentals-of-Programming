using System;
using System.Text;

class Bai05
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.WriteLine("KIỂM TRA LOẠI KÝ TỰ");

        Console.Write("Nhập vào 1 ký tự: ");
        string chuoiNhap = Console.ReadLine()!;

        if (string.IsNullOrEmpty(chuoiNhap))
        {
            Console.WriteLine("Lỗi: Bạn chưa nhập ký tự nào!");
        }
        else
        {
            char kyTu = chuoiNhap[0];
            char kyTuThuong = char.ToLower(kyTu);

            if (char.IsDigit(kyTu))
            {
                Console.WriteLine($"'{kyTu}' là CHỮ SỐ.");
            }
            else if ("aeiou".Contains(kyTuThuong))
            {
                Console.WriteLine($"'{kyTu}' là NGUYÊN ÂM (Vowel).");
            }
            else if (char.IsLetter(kyTu))
            {
                Console.WriteLine($"'{kyTu}' là PHỤ ÂM (Consonant).");
            }
            else
            {
                Console.WriteLine($"'{kyTu}' là KÝ TỰ ĐẶC BIỆT / BIỂU TƯỢNG (Symbol).");
            }
        }

        Console.WriteLine("\nBấm phím bất kỳ để thoát...");
        Console.ReadKey();
    }
}