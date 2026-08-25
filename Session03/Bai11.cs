using System;
using System.Text;

class Bai11
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.WriteLine("=== TÍNH LÃI SUẤT TIẾT KIỆM (ĐƠN VS KÉP) ===");

        decimal tienGui = NhapSoDecimal("Nhập số tiền gửi (VNĐ): ");
        double laiSuatNam = (double)NhapSoDecimal("Nhập lãi suất năm (%): ");
        int soThang = (int)NhapSoDecimal("Nhập thời gian gửi (tháng): ");

        decimal laiDon = tienGui * (decimal)(laiSuatNam / 100.0) * (soThang / 12.0m);

        double tongTienKepDouble = (double)tienGui * Math.Pow(1 + (laiSuatNam / 100.0) / 12.0, soThang);
        decimal tongTienKep = (decimal)tongTienKepDouble;
        decimal laiKep = tongTienKep - tienGui;

        decimal chenhLech = laiKep - laiDon;

        Console.WriteLine($"\nLãi đơn nhận được: {laiDon:#,##0} VNĐ");
        Console.WriteLine($"Lãi kép nhận được: {laiKep:#,##0} VNĐ");
        Console.WriteLine($"Chênh lệch lợi nhuận: {chenhLech:#,##0} VNĐ (Lãi kép tối ưu hơn)");

        Console.ReadKey();
    }

    static decimal NhapSoDecimal(string ghiChu)
    {
        decimal giaTri;
        while (true)
        {
            Console.Write(ghiChu);
            if (decimal.TryParse(Console.ReadLine(), out giaTri) && giaTri > 0) return giaTri;
            Console.WriteLine("Lỗi: Vui lòng nhập số > 0!");
        }
    }
}