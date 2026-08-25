using System;
using System.Globalization;
using System.Text;

enum LoaiXe { XeMay = 0, ÔTô = 1, XeTai = 2 }

class Bai13
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.WriteLine("TÍNH PHÍ BÃI ĐỖ XE THÔNG MINH");

        Console.Write("Loại xe (0-Xe máy, 1-Ô tô, 2-Xe tải): ");
        LoaiXe loaiXe = (LoaiXe)int.Parse(Console.ReadLine()!);

        DateTime thoiGianVao = NhapThoiGian("Nhập giờ vào (yyyy-MM-dd HH:mm): ");
        DateTime thoiGianRa = NhapThoiGian("Nhập giờ ra (yyyy-MM-dd HH:mm): ");

        double tongSoGioDouble = (thoiGianRa - thoiGianVao).TotalHours;
        int soGioTinhPhi = (int)Math.Ceiling(tongSoGioDouble);

        decimal giaCoBan = 0, giaGioTiepTheo = 0;
        switch (loaiXe)
        {
            case LoaiXe.XeMay: giaCoBan = 5000m; giaGioTiepTheo = 2000m; break;
            case LoaiXe.ÔTô: giaCoBan = 20000m; giaGioTiepTheo = 10000m; break;
            case LoaiXe.XeTai: giaCoBan = 50000m; giaGioTiepTheo = 25000m; break;
        }

        decimal tongPhi = 0;
        decimal phiHaiGioDau = giaCoBan;
        decimal phiGioThem = 0;

        if (soGioTinhPhi <= 2)
        {
            tongPhi = giaCoBan;
        }
        else
        {
            int soGioThem = soGioTinhPhi - 2;
            phiGioThem = soGioThem * giaGioTiepTheo;
            tongPhi = giaCoBan + phiGioThem;
        }

        if (thoiGianRa.Date > thoiGianVao.Date)
        {
            tongPhi += 30000m; // Phụ phí qua đêm
        }

        Console.WriteLine($"\nTổng thời gian gửi: {tongSoGioDouble:F2} giờ -> Tính: {soGioTinhPhi} giờ");
        Console.WriteLine($"Phí 2 giờ đầu: {phiHaiGioDau:#,##0} VNĐ");
        Console.WriteLine($"Phí các giờ tiếp theo: {phiGioThem:#,##0} VNĐ");
        Console.WriteLine($"TỔNG PHÍ GỬI XE: {tongPhi:#,##0} VNĐ");

        Console.ReadKey();
    }

    static DateTime NhapThoiGian(string ghiChu)
    {
        DateTime dt;
        while (true)
        {
            Console.Write(ghiChu);
            if (DateTime.TryParseExact(Console.ReadLine(), "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out dt))
                return dt;
            Console.WriteLine("Lỗi: Định dạng phải là yyyy-MM-dd HH:mm (Ví dụ: 2026-08-24 14:30)");
        }
    }
}