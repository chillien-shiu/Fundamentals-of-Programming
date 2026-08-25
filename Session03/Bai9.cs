using System;
using System.Text;

class Bai09
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.WriteLine("=== CHUYỂN ĐỔI LƯƠNG GROSS SANG NET ===");

        decimal luongGross = NhapSoDecimal("Nhập lương Gross (VNĐ): ");
        int soNguoiPhuThuoc = (int)NhapSoDecimal("Nhập số người phụ thuộc: ");

        decimal baoHiem = luongGross * 0.105m;
        decimal giamTruBanThan = 11000000m;
        decimal giamTruPhuThuoc = soNguoiPhuThuoc * 4400000m;

        decimal thuNhapChiuThue = luongGross - baoHiem - giamTruBanThan - giamTruPhuThuoc;
        if (thuNhapChiuThue < 0) thuNhapChiuThue = 0;

        decimal thueTncn = 0;
        decimal thuNhapConLai = thuNhapChiuThue;

        if (thuNhapConLai > 0)
        {
            if (thuNhapConLai <= 5000000m) thueTncn += thuNhapConLai * 0.05m;
            else
            {
                thueTncn += 5000000m * 0.05m;
                thuNhapConLai -= 5000000m;

                if (thuNhapConLai <= 5000000m) thueTncn += thuNhapConLai * 0.10m;
                else
                {
                    thueTncn += 5000000m * 0.10m;
                    thuNhapConLai -= 5000000m;

                    if (thuNhapConLai <= 8000000m) thueTncn += thuNhapConLai * 0.15m;
                    else
                    {
                        thueTncn += 8000000m * 0.15m;
                        thuNhapConLai -= 8000000m;
                        thueTncn += thuNhapConLai * 0.20m;
                    }
                }
            }
        }

        decimal luongNet = luongGross - baoHiem - thueTncn;

        Console.WriteLine($"\nBảo hiểm bắt buộc (10.5%): {baoHiem:#,##0} VNĐ");
        Console.WriteLine($"Thu nhập chịu thuế: {thuNhapChiuThue:#,##0} VNĐ");
        Console.WriteLine($"Thuế TNCN phải nộp: {thueTncn:#,##0} VNĐ");
        Console.WriteLine($"LƯƠNG NET THỰC NHẬN: {luongNet:#,##0} VNĐ");

        Console.ReadKey();
    }

    static decimal NhapSoDecimal(string ghiChu)
    {
        decimal giaTri;
        while (true)
        {
            Console.Write(ghiChu);
            if (decimal.TryParse(Console.ReadLine(), out giaTri) && giaTri >= 0) return giaTri;
            Console.WriteLine("Lỗi: Vui lòng nhập số hợp lệ >= 0!");
        }
    }
}