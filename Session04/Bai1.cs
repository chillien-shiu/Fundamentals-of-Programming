using System;
using System.Text;

class Bai01
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.WriteLine("TÍNH TOÁN 2 SỐ");

        double soThuNhat = NhapSoDouble("Nhập số thứ nhất: ");

        Console.Write("Nhập phép tính (+, -, *, /): ");
        char phepTinh = Console.ReadLine()![0];

        double soThuHai = NhapSoDouble("Nhập số thứ hai: ");
        double ketQua = 0;
        bool hopLe = true;

        switch (phepTinh)
        {
            case '+': ketQua = soThuNhat + soThuHai; break;
            case '-': ketQua = soThuNhat - soThuHai; break;
            case '*': ketQua = soThuNhat * soThuHai; break;
            case '/':
                if (soThuHai != 0) ketQua = soThuNhat / soThuHai;
                else { Console.WriteLine("Lỗi: Không thể chia cho 0!"); hopLe = false; }
                break;
            default:
                Console.WriteLine("Lỗi: Phép tính không hợp lệ!");
                hopLe = false;
                break;
        }

        if (hopLe)
        {
            Console.WriteLine($"\nKết quả: {soThuNhat} {phepTinh} {soThuHai} = {ketQua}");
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
            if (double.TryParse(Console.ReadLine(), out giaTri)) return giaTri;
            Console.WriteLine("Lỗi: Vui lòng nhập số hợp lệ!");
        }
    }
}