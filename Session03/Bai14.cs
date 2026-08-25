using System;
using System.Text;

class Bai14
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.WriteLine("KIỂM TRA CHUỖI SỐ & TRÀN SỐ");

        Console.Write("Nhập vào chuỗi số: ");
        string chuoiNhap = Console.ReadLine()!;

        if (int.TryParse(chuoiNhap, out int soNguyen))
        {
            Console.WriteLine($"✅ Chuyển đổi thành công! Giá trị int = {soNguyen}");

            bool laKieuByte = soNguyen >= byte.MinValue && soNguyen <= byte.MaxValue;
            Console.WriteLine($"Phù hợp kiểu byte: {(laKieuByte ? "CÓ (Từ 0 đến 255)" : "KHÔNG")}");

            int tongCacChuSo = 0;
            int bienTam = Math.Abs(soNguyen);
            while (bienTam > 0)
            {
                tongCacChuSo += bienTam % 10;
                bienTam /= 10;
            }
            Console.WriteLine($"Tổng các chữ số: {tongCacChuSo}");

            try
            {
                checked
                {
                    int ketQuaNhan = soNguyen * 10000000;
                    Console.WriteLine("Kiểm tra tràn số: An toàn trong dải int32.");
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine(" Kiểm tra tràn số: CẢNH BÁO TRÀN SỐ (OverflowException)!");
            }
        }
        else
        {
            Console.WriteLine(" Lỗi: Chuỗi nhập vào không phải là số nguyên hợp lệ!");
        }

        Console.ReadKey();
    }
}