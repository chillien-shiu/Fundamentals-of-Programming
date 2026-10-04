using System;
using System.IO;
using System.Text;

class QuanLyTapTin
{
    static string duongDanFile = "du_lieu_mau.txt";

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        while (true)
        {
            Console.Clear();
            Console.WriteLine("      BÀI TẬP THAO TÁC TẬP TÍN (FILE) C#          ");
            Console.WriteLine(" 1. Tạo một file rỗng");
            Console.WriteLine(" 2. Xóa một file khỏi đĩa");
            Console.WriteLine(" 3. Tạo file và ghi văn bản");
            Console.WriteLine(" 4. Đọc nội dung từ file");
            Console.WriteLine(" 5. Ghi một mảng chuỗi vào file");
            Console.WriteLine(" 6. Nối (thêm) văn bản vào file hiện có");
            Console.WriteLine(" 7. Sao chép file sang tên mới và hiển thị");
            Console.WriteLine(" 8. Đổi tên / Di chuyển file trong cùng thư mục");
            Console.WriteLine(" 9. Đọc dòng đầu tiên của file");
            Console.WriteLine("10. Đọc dòng cuối cùng của file");
            Console.WriteLine("11. Đọc n dòng cuối cùng của file");
            Console.WriteLine("12. Đọc một dòng cụ thể theo số thứ tự");
            Console.WriteLine("13. Đếm tổng số dòng trong file");
            Console.WriteLine("14. In cấu trúc thư mục (bao gồm các file)");
            Console.WriteLine("15. Thống kê ký tự/chữ số (Mảng 2 chiều & Mảng ziczac)");
            Console.WriteLine(" 0. Thoát chương trình");
            Console.Write("Nhập lựa chọn của bạn (0-15): ");

            if (!int.TryParse(Console.ReadLine(), out int chon)) continue;
            if (chon == 0) break;

            Console.WriteLine($"\n---> KẾT QUẢ CÂU {chon} <---");
            GoiHamTheoLuaChon(chon);

            Console.WriteLine("\nBấm phím bất kỳ để quay lại menu...");
            Console.ReadKey();
        }
    }

    static void GoiHamTheoLuaChon(int chon)
    {
        switch (chon)
        {
            case 1: TaoFileRong(); break;
            case 2: XoaFile(); break;
            case 3: TaoFileVaGhiVanBan(); break;
            case 4: DocVanBanTuFile(); break;
            case 5: GhiMangChuoiVaoFile(); break;
            case 6: NoiThanhVanBanVaoFile(); break;
            case 7: SaoChepFile(); break;
            case 8: DoiTenHoacDiChuyenFile(); break;
            case 9: DocDongDauTien(); break;
            case 10: DocDongCuoiCung(); break;
            case 11: DocNDongCuoiCung(3); break; 
            case 12: DocDongCuThe(2); break;     
            case 13: DemSoDongTrongFile(); break;
            case 14: InCauTrucThuMuc(); break;
            case 15: ThongKeKyTuVaMangRangCua(); break;
            default: Console.WriteLine("Lựa chọn không hợp lệ!"); break;
        }
    }

    static void TaoFileRong()
    {
        using (File.Create(duongDanFile)) { }
        Console.WriteLine($"Đã tạo file rỗng thành công: {duongDanFile}");
    }

    static void XoaFile()
    {
        if (File.Exists(duongDanFile))
        {
            File.Delete(duongDanFile);
            Console.WriteLine($"Đã xóa file: {duongDanFile}");
        }
        else
        {
            Console.WriteLine("File không tồn tại để xóa.");
        }
    }

    static void TaoFileVaGhiVanBan()
    {
        File.WriteAllText(duongDanFile, "Dòng 1: Xin chào UEH\nDòng 2: Lập trình C# cơ bản\n");
        Console.WriteLine("Đã ghi văn bản vào file.");
    }

    static void DocVanBanTuFile()
    {
        if (File.Exists(duongDanFile))
        {
            string noiDung = File.ReadAllText(duongDanFile);
            Console.WriteLine("Nội dung file:\n" + noiDung);
        }
        else
        {
            Console.WriteLine("File chưa tồn tại. Hãy tạo file trước!");
        }
    }

    static void GhiMangChuoiVaoFile()
    {
        string[] danhSach = { "Lập trình CSLT", "Khoa Công nghệ Thông tin Kinh doanh", "Ngôn ngữ C#" };
        File.WriteAllLines(duongDanFile, danhSach);
        Console.WriteLine("Đã ghi mảng chuỗi vào file.");
    }

    static void NoiThanhVanBanVaoFile()
    {
        File.AppendAllText(duongDanFile, "Dòng mới được nối thêm vào cuối file.\n");
        Console.WriteLine("Đã nối thêm văn bản.");
    }

    static void SaoChepFile()
    {
        string fileSaochep = "file_sao_chep.txt";
        File.Copy(duongDanFile, fileSaochep, true);
        Console.WriteLine($"Đã sao chép sang {fileSaochep}. Nội dung file mới:\n" + File.ReadAllText(fileSaochep));
    }

    static void DoiTenHoacDiChuyenFile()
    {
        string fileMoi = "file_da_doi_ten.txt";
        if (File.Exists(fileMoi)) File.Delete(fileMoi);
        File.Move(duongDanFile, fileMoi);
        Console.WriteLine($"Đã đổi tên/di chuyển file thành: {fileMoi}");

        // Đổi tên ngược lại để không làm đứt đoạn các câu tiếp theo
        File.Move(fileMoi, duongDanFile);
    }

    static void DocDongDauTien()
    {
        if (File.Exists(duongDanFile))
        {
            using (StreamReader sr = new StreamReader(duongDanFile))
            {
                Console.WriteLine("Dòng đầu tiên: " + sr.ReadLine());
            }
        }
    }

    static void DocDongCuoiCung()
    {
        if (File.Exists(duongDanFile))
        {
            string[] cacDong = File.ReadAllLines(duongDanFile);
            if (cacDong.Length > 0)
                Console.WriteLine("Dòng cuối cùng: " + cacDong[cacDong.Length - 1]);
        }
    }

    static void DocNDongCuoiCung(int soDongToiDa)
    {
        if (File.Exists(duongDanFile))
        {
            string[] cacDong = File.ReadAllLines(duongDanFile);
            Console.WriteLine($"{soDongToiDa} dòng cuối cùng:");
            int viTriBatDau = Math.Max(0, cacDong.Length - soDongToiDa);
            for (int i = viTriBatDau; i < cacDong.Length; i++)
            {
                Console.WriteLine(cacDong[i]);
            }
        }
    }

    static void DocDongCuThe(int soThuTuDong)
    {
        if (File.Exists(duongDanFile))
        {
            string[] cacDong = File.ReadAllLines(duongDanFile);
            if (soThuTuDong >= 1 && soThuTuDong <= cacDong.Length)
                Console.WriteLine($"Nội dung dòng {soThuTuDong}: " + cacDong[soThuTuDong - 1]);
            else
                Console.WriteLine("Vị trí dòng vượt quá số dòng hiện có.");
        }
    }

    static void DemSoDongTrongFile()
    {
        if (File.Exists(duongDanFile))
        {
            int tongSoDong = File.ReadAllLines(duongDanFile).Length;
            Console.WriteLine($"Tổng số dòng trong file: {tongSoDong}");
        }
    }

    static void InCauTrucThuMuc()
    {
        string thuMucHienTai = Directory.GetCurrentDirectory();
        Console.WriteLine($"Cấu trúc thư mục hiện tại [{thuMucHienTai}]:");

        foreach (string file in Directory.GetFiles(thuMucHienTai))
        {
            Console.WriteLine("  ├── File: " + Path.GetFileName(file));
        }
    }
  static void ThongKeKyTuVaMangRangCua()
    {
        if (!File.Exists(duongDanFile))
            File.WriteAllText(duongDanFile, "ABC123\nXYZ89\nCSLT2026");

        string[] cacDong = File.ReadAllLines(duongDanFile);

        // a) Thống kê số lượng chữ cái và chữ số
        int soChuCai = 0, soChuSo = 0;
        foreach (string dong in cacDong)
        {
            foreach (char c in dong)
            {
                if (char.IsLetter(c)) soChuCai++;
                else if (char.IsDigit(c)) soChuSo++;
            }
        }
        Console.WriteLine($"Thống kê tổng: {soChuCai} chữ cái, {soChuSo} chữ số.");

        //b. Dùng mảng răng cưa lưu từng dòng ký tự và in vị trí (dòng, cột)[cite: 3]
        char[][] mangRangCua = new char[cacDong.Length][];
        Console.WriteLine("\nVị trí xuất hiện từng ký tự (dòng, cột):");
        for (int i = 0; i < cacDong.Length; i++)
        {
            mangRangCua[i] = cacDong[i].ToCharArray();
            for (int j = 0; j < mangRangCua[i].Length; j++)
            {
                Console.WriteLine($"Dòng {i + 1}, Cột {j + 1}: '{mangRangCua[i][j]}'");
            }
        }
    }
}