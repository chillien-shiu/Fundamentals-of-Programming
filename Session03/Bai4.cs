using System;
using System.Globalization;
using System.Text;

class Bai04
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.WriteLine("TÍNH TUỔI & ĐẾM NGƯỢC SINH NHẬT");

        DateTime ngaySinh;
        while (true)
        {
            Console.Write("Nhập ngày sinh (dd/MM/yyyy): ");
            string chuoiNgay = Console.ReadLine()!;
            if (DateTime.TryParseExact(chuoiNgay, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngaySinh))
                break;
            Console.WriteLine("Lỗi: Định dạng ngày sinh không hợp lệ!");
        }

        DateTime ngayHienTai = DateTime.Now.Date;

        int tuoi = ngayHienTai.Year - ngaySinh.Year;
        if (ngaySinh.Date > ngayHienTai.AddYears(-tuoi)) tuoi--;

        int tongSoNgayDaSong = (int)(ngayHienTai - ngaySinh).TotalDays;

        DateTime sinhNhatKeTiep = new DateTime(ngayHienTai.Year, ngaySinh.Month, ngaySinh.Day);
        if (sinhNhatKeTiep < ngayHienTai) sinhNhatKeTiep = sinhNhatKeTiep.AddYears(1);

        int soNgayDenSinhNhat = (sinhNhatKeTiep - ngayHienTai).Days;

        Console.WriteLine($"\nTuổi hiện tại: {tuoi} tuổi");
        Console.WriteLine($"Tổng số ngày đã sống: {tongSoNgayDaSong:#,##0} ngày");
        Console.WriteLine($"Sinh nhật tiếp theo còn: {soNgayDenSinhNhat} ngày nữa");

        Console.ReadKey();
    }
}