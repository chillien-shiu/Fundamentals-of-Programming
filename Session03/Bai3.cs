using System;
using System.Text;

enum LoaiNgoaiTe { USD = 1, EUR, JPY, GBP }

class Bai03
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.WriteLine("=== CHƯƠNG TRÌNH QUY ĐỔI NGOẠI TỆ ===");

        decimal soTienVnd = NhapSoDecimal("Nhập số tiền VNĐ: ");

        Console.WriteLine("1. USD | 2. EUR | 3. JPY | 4. GBP");
        int luaChon = (int)NhapSoDecimal("Chọn loại ngoại tệ (1-4): ");
        LoaiNgoaiTe loaiTien = (LoaiNgoaiTe)luaChon;

        decimal tyGia = loaiTien switch
        {
            LoaiNgoaiTe.USD => 25400m,
            LoaiNgoaiTe.EUR => 27200m,
            LoaiNgoaiTe.JPY => 165m,
            LoaiNgoaiTe.GBP => 32100m,
            _ => 25400m
        };

        decimal phiDichVu = soTienVnd * 0.005m;
        decimal tienThucDoi = soTienVnd - phiDichVu;
        decimal tienNgoaiTe = tienThucDoi / tyGia;

        Console.WriteLine($"\nPhí dịch vụ (0.5%): {phiDichVu:#,##0} VNĐ");
        Console.WriteLine($"Số tiền VNĐ tính đổi: {tienThucDoi:#,##0} VNĐ");
        Console.WriteLine($"Số tiền {loaiTien} nhận được: {tienNgoaiTe:N2} {loaiTien}");

        Console.ReadKey();
    }

    static decimal NhapSoDecimal(string ghiChu)
    {
        decimal giaTri;
        while (true)
        {
            Console.Write(ghiChu);
            if (decimal.TryParse(Console.ReadLine(), out giaTri) && giaTri > 0) return giaTri;
            Console.WriteLine("Lỗi: Vui lòng nhập số hợp lệ > 0!");
        }
    }
}