using System;
using System.Text;

class Bai07
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.WriteLine("=== TÍNH CHI PHÍ XĂNG XE CHUNG ===");

        double quangDuong = NhapSoDouble("Nhập quãng đường (km): ");
        double mucTieuThieu = NhapSoDouble("Nhập mức tiêu hao (Lít/100km): ");
        decimal giaXang = NhapSoDecimal("Nhập giá xăng (VNĐ/Lít): ");
        int soNguoi = (int)NhapSoDecimal("Nhập số người đi chung: ");

        double tongSoLit = (quangDuong / 100.0) * mucTieuThieu;
        decimal tongChiPhi = (decimal)tongSoLit * giaXang;

        decimal chiPhiMoiNguoi = tongChiPhi / soNguoi;
        decimal chiPhiLamTron = Math.Ceiling(chiPhiMoiNguoi / 1000m) * 1000m;

        Console.WriteLine($"\nTổng nhiên liệu tiêu thụ: {tongSoLit:F2} Lít");
        Console.WriteLine($"Tổng chi phí xăng dầu: {tongChiPhi:#,##0} VNĐ");
        Console.WriteLine($"Chi phí mỗi người (làm tròn): {chiPhiLamTron:#,##0} VNĐ");

        Console.ReadKey();
    }

    static double NhapSoDouble(string ghiChu)
    {
        double giaTri;
        while (true)
        {
            Console.Write(ghiChu);
            if (double.TryParse(Console.ReadLine(), out giaTri) && giaTri > 0) return giaTri;
            Console.WriteLine("Lỗi: Vui lòng nhập số > 0!");
        }
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