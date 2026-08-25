using System;
using System.Linq;
using System.Text;

class Bai08
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.WriteLine("HỆ THỐNG XÁC THỰC MÃ OTP");

        string maOtpChuan = "839201";
        DateTime thoiGianTao = DateTime.Now;

        Console.Write("Nhập mã OTP nhận được: ");
        string maOtpNhap = Console.ReadLine()!;

        Console.Write("Nhập số giây giả lập trôi qua: ");
        int soGiayTroiQua = int.Parse(Console.ReadLine()!);

        DateTime thoiGianXacThuc = thoiGianTao.AddSeconds(soGiayTroiQua);
        TimeSpan khoangThoiGian = thoiGianXacThuc - thoiGianTao;

        if (maOtpNhap.Length != 6 || !maOtpNhap.All(char.IsDigit))
        {
            Console.WriteLine("\n Trạng thái: LỖI - Định dạng OTP phải đủ 6 chữ số!");
        }
        else if (khoangThoiGian.TotalMinutes > 5)
        {
            Console.WriteLine("\n Trạng thái: LỖI - Mã OTP đã hết hạn (Quá 5 phút)!");
        }
        else if (maOtpNhap != maOtpChuan)
        {
            Console.WriteLine("\n Trạng thái: LỖI - Mã OTP không chính xác!");
        }
        else
        {
            Console.WriteLine("\n Trạng thái: THÀNH CÔNG! Giao dịch hợp lệ.");
        }

        Console.ReadKey();
    }
}