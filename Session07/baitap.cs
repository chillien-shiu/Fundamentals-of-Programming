using System;
using System.Text;

class QuanLyChuoi
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        while (true)
        {
            Console.Clear();
            Console.WriteLine("BÀI TẬP XỬ LÝ CHUỖI (STRING) C#");
            Console.WriteLine(" 1. Nhập và in chuỗi");
            Console.WriteLine(" 2. Tính độ dài chuỗi (không dùng hàm thư viện)");
            Console.WriteLine(" 3. Tách từng ký tự trong chuỗi");
            Console.WriteLine(" 4. In chuỗi theo thứ tự đảo ngược");
            Console.WriteLine(" 5. Đếm tổng số từ trong chuỗi");
            Console.WriteLine(" 6. So sánh 2 chuỗi (không dùng hàm thư viện)");
            Console.WriteLine(" 7. Đếm chữ cái, chữ số và ký tự đặc biệt");
            Console.WriteLine(" 8. Đếm số nguyên âm và phụ âm");
            Console.WriteLine(" 9. Kiểm tra chuỗi con có tồn tại không");
            Console.WriteLine("10. Tìm vị trí xuất hiện của chuỗi con");
            Console.WriteLine("11. Kiểm tra ký tự (có phải chữ cái không, hoa/thường)");
            Console.WriteLine("12. Đếm số lần xuất hiện của chuỗi con");
            Console.WriteLine("13. Chèn chuỗi con vào trước vị trí xuất hiện đầu tiên");
            Console.WriteLine(" 0. Thoát chương trình");
            Console.Write("Nhập lựa chọn câu (0-13): ");

            if (!int.TryParse(Console.ReadLine(), out int chon)) continue;
            if (chon == 0) break;

            Console.WriteLine($"\n---> KẾT QUẢ CÂU {chon} <---");
            GoiHamXuLyChuoi(chon);

            Console.WriteLine("\nBấm phím bất kỳ để quay lại menu...");
            Console.ReadKey();
        }
    }

    static void GoiHamXuLyChuoi(int chon)
    {
        switch (chon)
        {
            case 1: Cau01_NhapVaInChuoi(); break;
            case 2: Cau02_TinhDoDaiKhongThuVien(); break;
            case 3: Cau03_TachTuNgKyTu(); break;
            case 4: Cau04_InChuoiDaoNguoc(); break;
            case 5: Cau05_DemSoTu(); break;
            case 6: Cau06_SoSanhHaiChuoiKhongThuVien(); break;
            case 7: Cau07_DemChuCaiSoKyTuDacBiet(); break;
            case 8: Cau08_DemNguyenAmPhuAm(); break;
            case 9: Cau09_KiemTraChuoiConTonTai(); break;
            case 10: Cau10_TimViTriChuoiCon(); break;
            case 11: Cau11_KiemTraKyTuHoaThuong(); break;
            case 12: Cau12_DemSoLanXuatHienChuoiCon(); break;
            case 13: Cau13_ChenChuoiConVaoTruoc(); break;
            default: Console.WriteLine("Lựa chọn không hợp lệ!"); break;
        }
    }

    static void Cau01_NhapVaInChuoi()
    {
        Console.Write("Nhập vào một chuỗi: ");
        string str = Console.ReadLine()!;
        Console.WriteLine($"Chuỗi vừa nhập là: {str}");
    }

    static void Cau02_TinhDoDaiKhongThuVien()
    {
        Console.Write("Nhập chuỗi: ");
        string str = Console.ReadLine()!;
        int doDai = 0;
        foreach (char c in str) doDai++;
        Console.WriteLine($"Độ dài chuỗi: {doDai}");
    }

    static void Cau03_TachTuNgKyTu()
    {
        Console.Write("Nhập chuỗi: ");
        string str = Console.ReadLine()!;
        Console.Write("Các ký tự: ");
        foreach (char c in str) Console.Write($"{c} ");
        Console.WriteLine();
    }

    static void Cau04_InChuoiDaoNguoc()
    {
        Console.Write("Nhập chuỗi: ");
        string str = Console.ReadLine()!;
        Console.Write("Chuỗi đảo ngược: ");
        for (int i = str.Length - 1; i >= 0; i--) Console.Write(str[i]);
        Console.WriteLine();
    }

    static void Cau05_DemSoTu()
    {
        Console.Write("Nhập chuỗi: ");
        string str = Console.ReadLine()!;
        string[] tu = str.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine($"Số từ trong chuỗi: {tu.Length}");
    }

    static void Cau06_SoSanhHaiChuoiKhongThuVien()
    {
        Console.Write("Nhập chuỗi thứ 1: ");
        string s1 = Console.ReadLine()!;
        Console.Write("Nhập chuỗi thứ 2: ");
        string s2 = Console.ReadLine()!;

        bool bangNhau = s1.Length == s2.Length;
        if (bangNhau)
        {
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != s2[i]) { bangNhau = false; break; }
            }
        }
        Console.WriteLine(bangNhau ? "Hai chuỗi BẰNG NHAU." : "Hai chuỗi KHÔNG BẰNG NHAU.");
    }

    static void Cau07_DemChuCaiSoKyTuDacBiet()
    {
        Console.Write("Nhập chuỗi: ");
        string str = Console.ReadLine()!;
        int chuCai = 0, chuSo = 0, dacBiet = 0;

        foreach (char c in str)
        {
            if (char.IsLetter(c)) chuCai++;
            else if (char.IsDigit(c)) chuSo++;
            else dacBiet++;
        }
        Console.WriteLine($"Chữ cái: {chuCai} | Chữ số: {chuSo} | Ký tự đặc biệt: {dacBiet}");
    }

    static void Cau08_DemNguyenAmPhuAm()
    {
        Console.Write("Nhập chuỗi: ");
        string str = Console.ReadLine()!.ToLower();
        int nguyenAm = 0, phuAm = 0;
        string dsNguyenAm = "aeiouáàảãạăắằẳẵặâấầẩẫậéèẻẽẹêếềểễệíìỉĩịóòỏõọôốồổỗộơớờởỡợúùủũụưứừửữựýỳỷỹỵ";

        foreach (char c in str)
        {
            if (char.IsLetter(c))
            {
                if (dsNguyenAm.Contains(c)) nguyenAm++;
                else phuAm++;
            }
        }
        Console.WriteLine($"Nguyên âm: {nguyenAm} | Phụ âm: {phuAm}");
    }

    static void Cau09_KiemTraChuoiConTonTai()
    {
        Console.Write("Nhập chuỗi gốc: ");
        string str = Console.ReadLine()!;
        Console.Write("Nhập chuỗi con: ");
        string sub = Console.ReadLine()!;
        Console.WriteLine(str.Contains(sub) ? "CÓ tồn tại." : "KHÔNG tồn tại.");
    }

    static void Cau10_TimViTriChuoiCon()
    {
        Console.Write("Nhập chuỗi gốc: ");
        string str = Console.ReadLine()!;
        Console.Write("Nhập chuỗi con: ");
        string sub = Console.ReadLine()!;

        int index = str.IndexOf(sub);
        Console.WriteLine(index != -1 ? $"Xuất hiện tại vị trí (index): {index}" : "Không tìm thấy.");
    }

    static void Cau11_KiemTraKyTuHoaThuong()
    {
        Console.Write("Nhập 1 ký tự: ");
        char c = Console.ReadKey().KeyChar;
        Console.WriteLine();

        if (char.IsLetter(c))
        {
            Console.WriteLine($"'{c}' là chữ cái ({(char.IsUpper(c) ? "Hoa" : "Thường")}).");
        }
        else
        {
            Console.WriteLine($"'{c}' không phải là chữ cái.");
        }
    }

    static void Cau12_DemSoLanXuatHienChuoiCon()
    {
        Console.Write("Nhập chuỗi gốc: ");
        string str = Console.ReadLine()!;
        Console.Write("Nhập chuỗi con: ");
        string sub = Console.ReadLine()!;

        int count = 0, index = 0;
        while ((index = str.IndexOf(sub, index)) != -1)
        {
            count++;
            index += sub.Length;
        }
        Console.WriteLine($"Số lần xuất hiện: {count}");
    }

    static void Cau13_ChenChuoiConVaoTruoc()
    {
        Console.Write("Nhập chuỗi gốc: ");
        string str = Console.ReadLine()!;
        Console.Write("Nhập chuỗi đích: ");
        string target = Console.ReadLine()!;
        Console.Write("Nhập chuỗi cần chèn: ");
        string insertStr = Console.ReadLine()!;

        int index = str.IndexOf(target);
        if (index != -1)
        {
            Console.WriteLine($"Kết quả: {str.Insert(index, insertStr)}");
        }
        else
        {
            Console.WriteLine("Không tìm thấy chuỗi đích!");
        }
    }
}