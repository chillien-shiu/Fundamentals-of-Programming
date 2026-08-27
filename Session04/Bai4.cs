using System;
using System.Text;

class Bai04
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.WriteLine("TÍNH DIỆN TÍCH VÀ THỂ TÍCH HÌNH CẦU");

        double banKinh = NhapSoDouble("Nhập bán kính hình cầu (r): ");

        double dienTich = 4 * Math.PI * Math.Pow(banKinh, 2);
        double theTich = (4.0 / 3.0) * Math.PI * Math.Pow(banKinh, 3);

        Console.WriteLine($"\nDiện tích bề mặt (S) = {dienTich:F2}");
        Console.WriteLine($"Thể tích hình cầu (V)  = {theTich:F2}");

        Console.WriteLine("\nBấm phím bất kỳ để thoát...");
        Console.ReadKey();
    }

    static double NhapSoDouble(string ghiChu)
    {
        double giaTri;
        while (true)
        {
            Console.Write(ghiChu);
            if (double.TryParse(Console.ReadLine(), out giaTri) && giaTri > 0) return giaTri;
            Console.WriteLine("Lỗi: Bán kính phải là số lớn hơn 0!");
        }
    }
}