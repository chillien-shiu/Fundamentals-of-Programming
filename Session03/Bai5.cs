using System;
using System.Text;

class Bai05
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.WriteLine("TÍNH ĐIỂM HỌC PHẦN & GPA");

        double diemCSharp = NhapDiem("Nhập điểm C# (4 TC): ");
        double diemToan = NhapDiem("Nhập điểm Toán (3 TC): ");
        double diemTiengAnh = NhapDiem("Nhập điểm Tiếng Anh (2 TC): ");

        int tcCSharp = 4, tcToan = 3, tcTiengAnh = 2;
        int tongTinChi = tcCSharp + tcToan + tcTiengAnh;

        double diemTrungBinh = (diemCSharp * tcCSharp + diemToan * tcToan + diemTiengAnh * tcTiengAnh) / tongTinChi;
        diemTrungBinh = Math.Round(diemTrungBinh, 2);

        char diemChu;
        double gpaThang4;
        string xepLoai;

        if (diemTrungBinh >= 8.5) { diemChu = 'A'; gpaThang4 = 4.0; xepLoai = "Xuất sắc / Giỏi"; }
        else if (diemTrungBinh >= 7.0) { diemChu = 'B'; gpaThang4 = 3.0; xepLoai = "Khá"; }
        else if (diemTrungBinh >= 5.5) { diemChu = 'C'; gpaThang4 = 2.0; xepLoai = "Trung bình"; }
        else if (diemTrungBinh >= 4.0) { diemChu = 'D'; gpaThang4 = 1.0; xepLoai = "Yếu"; }
        else { diemChu = 'F'; gpaThang4 = 0.0; xepLoai = "Kém (Trượt)"; }

        Console.WriteLine($"\nĐiểm TB Thang 10: {diemTrungBinh:F2}");
        Console.WriteLine($"Điểm Chữ Quy Đổi: {diemChu}");
        Console.WriteLine($"Điểm GPA Thang 4: {gpaThang4:F1}");
        Console.WriteLine($"Xếp Loại Học Lực: {xepLoai}");

        Console.ReadKey();
    }

    static double NhapDiem(string ghiChu)
    {
        double diem;
        while (true)
        {
            Console.Write(ghiChu);
            if (double.TryParse(Console.ReadLine(), out diem) && diem >= 0 && diem <= 10) return diem;
            Console.WriteLine("Lỗi: Điểm phải từ 0 đến 10!");
        }
    }
}