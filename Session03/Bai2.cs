using System;
using System.Text;

class Bai02
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.WriteLine("CHƯƠNG TRÌNH TÍNH CHỈ SỐ BMI");

        double chieuCao = NhapSoDouble("Nhập chiều cao (m): ");
        double canNang = NhapSoDouble("Nhập cân nặng (kg): ");

        double bmi = Math.Round(canNang / (chieuCao * chieuCao), 2);

        string phanLoai = bmi switch
        {
            < 18.5 => "Gầy (Thiếu cân)",
            >= 18.5 and < 23.0 => "Bình thường (Lý tưởng)",
            >= 23.0 and < 25.0 => "Thừa cân (Tiền béo phì)",
            _ => "Béo phì"
        };

        double canNangToiThieu = Math.Round(18.5 * chieuCao * chieuCao, 2);
        double canNangToiDa = Math.Round(22.9 * chieuCao * chieuCao, 2);

        Console.WriteLine($"\nChỉ số BMI: {bmi:F2}");
        Console.WriteLine($"Phân loại: {phanLoai}");
        Console.WriteLine($"Cân nặng lý tưởng khuyên dùng: {canNangToiThieu:F2} kg - {canNangToiDa:F2} kg");

        Console.ReadKey();
    }

    static double NhapSoDouble(string ghiChu)
    {
        double giaTri;
        while (true)
        {
            Console.Write(ghiChu);
            if (double.TryParse(Console.ReadLine(), out giaTri) && giaTri > 0) return giaTri;
            Console.WriteLine("Lỗi: Vui lòng nhập số hợp lệ > 0!");
        }
    }
}