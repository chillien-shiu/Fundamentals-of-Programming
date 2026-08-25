using System;
using System.Text;

class CSLTB3
{
    static void Main1()
    {
        // Cấu hình hiển thị tiếng Việt trên Console
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.WriteLine("=== CHƯƠNG TRÌNH TÍNH TIỀN ĐIỆN SINH HOẠT (EVN) ===");

        // 1. Nhập chỉ số điện
        decimal chiSoCu = NhapSoDecimal("Nhập chỉ số điện cũ (kWh): ");
        decimal chiSoMoi;

        while (true)
        {
            chiSoMoi = NhapSoDecimal("Nhập chỉ số điện mới (kWh): ");
            if (chiSoMoi >= chiSoCu)
            {
                break;
            }
            Console.WriteLine("❌ Lỗi: Chỉ số mới phải lớn hơn hoặc bằng chỉ số cũ. Vui lòng nhập lại!");
        }

        decimal kwh = chiSoMoi - chiSoCu;
        decimal tienChuaThue = 0m;

        decimal kwhConLai = kwh;

        // Bậc 1: 0 - 50 kWh (50 kWh đầu) -> 1.806 VNĐ/kWh
        if (kwhConLai > 0)
        {
            decimal soKwhBac1 = Math.Min(kwhConLai, 50m);
            tienChuaThue += soKwhBac1 * 1806m;
            kwhConLai -= soKwhBac1;
        }

        // Bậc 2: 51 - 100 kWh (50 kWh tiếp) -> 1.866 VNĐ/kWh
        if (kwhConLai > 0)
        {
            decimal soKwhBac2 = Math.Min(kwhConLai, 50m);
            tienChuaThue += soKwhBac2 * 1866m;
            kwhConLai -= soKwhBac2;
        }

        // Bậc 3: 101 - 200 kWh (100 kWh tiếp) -> 2.167 VNĐ/kWh
        if (kwhConLai > 0)
        {
            decimal soKwhBac3 = Math.Min(kwhConLai, 100m);
            tienChuaThue += soKwhBac3 * 2167m;
            kwhConLai -= soKwhBac3;
        }

        // Bậc 4: 201 - 300 kWh (100 kWh tiếp) -> 2.729 VNĐ/kWh
        if (kwhConLai > 0)
        {
            decimal soKwhBac4 = Math.Min(kwhConLai, 100m);
            tienChuaThue += soKwhBac4 * 2729m;
            kwhConLai -= soKwhBac4;
        }

        // Bậc 5: Từ 301 kWh trở lên -> 3.050 VNĐ/kWh
        if (kwhConLai > 0)
        {
            tienChuaThue += kwhConLai * 3050m;
        }

        decimal thueVAT = tienChuaThue * 0.08m;
        decimal tongTien = tienChuaThue + thueVAT;

        tienChuaThue = Math.Round(tienChuaThue, MidpointRounding.AwayFromZero);
        thueVAT = Math.Round(thueVAT, MidpointRounding.AwayFromZero);
        tongTien = Math.Round(tongTien, MidpointRounding.AwayFromZero);

        
        Console.WriteLine($"• Điện tiêu thụ       : {kwh:#,##0} kWh");
        Console.WriteLine($"• Tiền điện (chưa thuế): {tienChuaThue:#,##0} VNĐ");
        Console.WriteLine($"• Thuế VAT (8%)       : {thueVAT:#,##0} VNĐ");
        Console.WriteLine($"• TỔNG TIỀN THANH TOÁN : {tongTien:#,##0} VNĐ");
        Console.ReadLine();
    }
    static decimal NhapSoDecimal(string ghiChu)
    {
        decimal giatri;
        while (true)
        {
            Console.Write(ghiChu);
            if (decimal.TryParse(Console.ReadLine(), out giatri) && giatri >= 0)
            {
                return giatri;
            }
            Console.WriteLine("❌ Lỗi: Vui lòng nhập một số hợp lệ lớn hơn hoặc bằng 0!");
        }
    }
    
}