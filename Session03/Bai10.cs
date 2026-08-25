using System;
using System.Text;

enum TrangThaiKho { HetHang, SapHetHang, ConHang }

class Bai10
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.WriteLine("=== QUẢN LÝ TỒN KHO SAN PHẨM ===");

        string maSanPham = "KB-09";
        string tenSanPham = "Bàn phím Cơ Akko";
        int? soLuongTon = null;
        int nguongToiThieu = 10;
        DateTime? ngayNhapHang = null;

        int soLuongHienThi = soLuongTon ?? 0;

        TrangThaiKho trangThai;
        if (soLuongTon == null || soLuongTon == 0)
        {
            trangThai = TrangThaiKho.HetHang;
        }
        else if (soLuongTon < nguongToiThieu)
        {
            trangThai = TrangThaiKho.SapHetHang;
        }
        else
        {
            trangThai = TrangThaiKho.ConHang;
        }

        string thongTinNgayNhap = ngayNhapHang?.ToString("dd/MM/yyyy") ?? "Chưa có lịch nhập";

        Console.WriteLine($"Sản phẩm: {tenSanPham} (Mã: {maSanPham})");
        Console.WriteLine($"Số lượng tồn: {soLuongHienThi} {(soLuongTon == null ? "(Dữ liệu trống)" : "")}");
        Console.WriteLine($"Trạng thái kho: {trangThai}");
        Console.WriteLine($"Dự kiến nhập hàng: {thongTinNgayNhap}");

        Console.ReadKey();
    }
}