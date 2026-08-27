using System;
using System.Text;

class Bai03
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.WriteLine("TÍNH TỐC ĐỘ DI CHUYỂN");

        double quangDuongKm = NhapSoDouble("Nhập quãng đường (km): ");
        double gio = NhapSoDouble("Nhập số giờ: ");
        double phut = NhapSoDouble("Nhập số phút: ");
        double giay = NhapSoDouble("Nhập số giây: ");

        // Quy đổi tổng thời gian ra giờ
        double tongThoiGianGio = gio + (phut / 60.0) + (giay / 3600.0);

        if (tongThoiGianGio <= 0)
        {
            Console.WriteLine("Lỗi: Tổng thời gian phải lớn hơn 0!");
        }
        else
        {
            double tocDoKmH = quangDuongKm / tongThoiGianGio;
            double tocDoMilesH = (quangDuongKm * 0.621371) / tongThoiGianGio;

            Console.WriteLine($"\nTốc độ (km/h)   : {tocDoKmH:F2} km/h");
            Console.WriteLine($"Tốc độ (miles/h): {tocDoMilesH:F2} miles/h");
        }

        Console.WriteLine("\nBấm phím bất kỳ để thoát...");
        Console.ReadKey();
    }

    static double NhapSoDouble(string ghiChu)
    {
        double giaTri;
        while (true)
        {
            Console.Write(ghiChu);
            if (double.TryParse(Console.ReadLine(), out giaTri) && giaTri >= 0) return giaTri;
            Console.WriteLine("Lỗi: Vui lòng nhập số hợp lệ >= 0!");
        }
    }
}