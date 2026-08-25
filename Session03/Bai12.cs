using System;
using System.Text;

class Bai12
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.WriteLine("MÃ HÓA VÀ GIẢI MÃ CAESAR CIPHER");

        Console.Write("Nhập văn bản gốc: ");
        string vanBanGoc = Console.ReadLine()!;

        Console.Write("Nhập khóa dịch chuyển (k): ");
        int khoaiKey = int.Parse(Console.ReadLine()!);

        string vanBanMaHoa = MaHoaCaesar(vanBanGoc, khoaiKey);
        string vanBanGiaiMa = MaHoaCaesar(vanBanMaHoa, -khoaiKey);

        Console.WriteLine($"\nVăn bản Mã hóa: {vanBanMaHoa}");
        Console.WriteLine($"Văn bản Giải mã: {vanBanGiaiMa}");

        Console.ReadKey();
    }

    static string MaHoaCaesar(string vanBan, int khoaiKey)
    {
        char[] mangKyTu = vanBan.ToCharArray();
        for (int i = 0; i < mangKyTu.Length; i++)
        {
            char kyTu = mangKyTu[i];
            if (char.IsUpper(kyTu))
            {
                int viTriMoi = (kyTu - 'A' + khoaiKey) % 26;
                if (viTriMoi < 0) viTriMoi += 26;
                mangKyTu[i] = (char)('A' + viTriMoi);
            }
            else if (char.IsLower(kyTu))
            {
                int viTriMoi = (kyTu - 'a' + khoaiKey) % 26;
                if (viTriMoi < 0) viTriMoi += 26;
                mangKyTu[i] = (char)('a' + viTriMoi);
            }
        }
        return new string(mangKyTu);
    }
}