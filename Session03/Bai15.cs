using System;
using System.Globalization;
using System.Text;

enum LoaiKhachHang { TreEm = 0, SinhVien = 1, NguoiLon = 2, NguoiCaoTuoi = 3 }

class Bai15
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.WriteLine("HỆ THỐNG ĐẶT VÉ RẠP CHIẾU PHIM");

        Console.Write("Loại khách (0-Trẻ em, 1-Sinh viên, 2-Người lớn, 3-Người cao tuổi): ");
        LoaiKhachHang loaiKhach = (LoaiKhachHang)int.Parse(Console.ReadLine()!);

        Console.Write("Có thẻ sinh viên hợp lệ không (true/false): ");
        bool coTheSinhVien = bool.Parse(Console.ReadLine()!);

        Console.Write("Nhập ngày xem phim (yyyy-MM-dd): ");
        DateTime ngayXem = DateTime.ParseExact(Console.ReadLine()!, "yyyy-MM-dd", CultureInfo.InvariantCulture);

        decimal giaVeGoc = 100000m;
        decimal mienGiam = 0m;
        decimal phuThuCuoiTuan = 0m;

        DayOfWeek thuTrongTuan = ngayXem.DayOfWeek;

        if (loaiKhach == LoaiKhachHang.TreEm || loaiKhach == LoaiKhachHang.NguoiCaoTuoi)
        {
            mienGiam = giaVeGoc * 0.5m;
        }
        else if (loaiKhach == LoaiKhachHang.SinhVien && coTheSinhVien && (thuTrongTuan >= DayOfWeek.Monday && thuTrongTuan <= DayOfWeek.Thursday))
        {
            mienGiam = giaVeGoc * 0.3m;
        }
        else if (loaiKhach == LoaiKhachHang.NguoiLon && thuTrongTuan == DayOfWeek.Wednesday)
        {
            mienGiam = giaVeGoc * 0.2m;
        }

        if (thuTrongTuan == DayOfWeek.Friday || thuTrongTuan == DayOfWeek.Saturday || thuTrongTuan == DayOfWeek.Sunday)
        {
            phuThuCuoiTuan = 20000m;
        }

        decimal tongTienVe = giaVeGoc - mienGiam + phuThuCuoiTuan;

        Console.WriteLine($"\nGiá vé gốc: {giaVeGoc:#,##0} VNĐ");
        Console.WriteLine($"Mức giảm giá: -{mienGiam:#,##0} VNĐ");
        Console.WriteLine($"Phụ thu cuối tuần: {phuThuCuoiTuan:#,##0} VNĐ");
        Console.WriteLine($"TỔNG TIỀN VÉ: {tongTienVe:#,##0} VNĐ");

        Console.ReadKey();
    }
}