using System;
using System.Globalization;
using System.Linq;
using System.Text;

class Bai06
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.WriteLine("CHUẨN HÓA HỌ TÊN & CẤP PHÁT EMAIL");

        Console.Write("Nhập họ và tên thô: ");
        string hoTenTho = Console.ReadLine()!;

        string[] cacTu = hoTenTho.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < cacTu.Length; i++)
        {
            cacTu[i] = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(cacTu[i].ToLower());
        }

        string hoTenChuanHoa = string.Join(" ", cacTu);
        string ho = cacTu[0];
        string ten = cacTu[^1];
        string tenDem = string.Join(" ", cacTu.Skip(1).Take(cacTu.Length - 2));

        string hoTenKhongDau = BoDauTiengViet(hoTenChuanHoa).ToLower();
        string[] cacTuKhongDau = hoTenKhongDau.Split(' ');
        string tenKhongDau = cacTuKhongDau[^1];
        string hoDemKhongDau = string.Join("", cacTuKhongDau.Take(cacTuKhongDau.Length - 1));

        string tenNguoiDung = $"{tenKhongDau}.{hoDemKhongDau}";
        string diaChiEmail = $"{tenNguoiDung}@company.edu.vn";

        Console.WriteLine($"\nHọ tên chuẩn hóa: {hoTenChuanHoa}");
        Console.WriteLine($"Họ: {ho} | Tên đệm: {tenDem} | Tên: {ten}");
        Console.WriteLine($"Tên đăng nhập: {tenNguoiDung}");
        Console.WriteLine($"Email cấp phát: {diaChiEmail}");

        Console.ReadKey();
    }

    static string BoDauTiengViet(string vanBan)
    {
        string chuoiChuanHoa = vanBan.Normalize(NormalizationForm.FormD);
        StringBuilder sb = new StringBuilder();
        foreach (char ch in chuoiChuanHoa)
        {
            if (CharUnicodeInfo.GetUnicodeCategory(ch) != UnicodeCategory.NonSpacingMark)
                sb.Append(ch);
        }
        return sb.ToString().Normalize(NormalizationForm.FormC).Replace('đ', 'd').Replace('Đ', 'D');
    }
}