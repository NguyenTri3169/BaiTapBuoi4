using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapBuoi4
{
    struct HoaDon
    {
        public string MaHoaDon;
        public DateTime NgayPhatHanh;
        public decimal SoTien;
        public string NguoiMua;
        public DateTime NgayMua;

        public static HoaDon NhapHoaDon()
        {
            HoaDon hd = new HoaDon();
            Console.Write("Nhap hoa don: ");
            hd.MaHoaDon = Console.ReadLine();
            Console.Write("Nhap ngay phat hanh: ");
            hd.NgayPhatHanh = DateTime.Parse(Console.ReadLine());
            Console.Write("Nhap so tien: ");
            hd.SoTien = decimal.Parse(Console.ReadLine());
            Console.Write("Nhap ten nguoi mua: ");
            hd.NguoiMua = Console.ReadLine();
            Console.Write("Nhap ngay mua: ");
            hd.NgayMua = DateTime.Parse(Console.ReadLine());
            return (hd);
        }

    }
    internal class Program
    {
        static List<HoaDon> dsHoaDon = new List<HoaDon>();

        static void Menu()
        {
            Console.WriteLine("==========MENU==========");
            Console.WriteLine("1.Nhap hoa don moi");
            Console.WriteLine("2.Xoa hoa don");
            Console.WriteLine("3.Sua hoa don");
            Console.WriteLine("4.Danh sach hoa don");
            Console.WriteLine("5.Tim kiem theo ma hoa don");
            Console.WriteLine("6.Thoat");
            Console.WriteLine("========================");
        }
        static void NhapHoaDonMoi()
        {
            HoaDon hd1 = HoaDon.NhapHoaDon();
            dsHoaDon.Add(hd1);
            Console.WriteLine("Hoa don duoc them vao ds");
        }

        static void XoaHoaDon()
        {
            Console.WriteLine("Nhap ma hoa don can xoa: ");
            string maHoaDon = Console.ReadLine();
            for (int i = 0; i < dsHoaDon.Count; i++)
            {
                if (dsHoaDon[i].MaHoaDon == maHoaDon)
                {
                    dsHoaDon.RemoveAt(i);
                    Console.WriteLine("Hoa don duoc xoa thanh cong");
                }
            }
            Console.WriteLine($"Khong tim thay ma hoa don can xoa {maHoaDon}");
        }
        static void SuaHoaDon()
        {
            Console.WriteLine("Nhap ma hoa don can sua: ");
            string maHoaDon = Console.ReadLine();
            for (int i = 0; i < dsHoaDon.Count; i++)
            {
                if (dsHoaDon[i].MaHoaDon == maHoaDon)
                {
                    HoaDon hdMoi = HoaDon.NhapHoaDon();
                    dsHoaDon[i] = hdMoi;
                    Console.WriteLine("Hoa don duoc sua thanh cong");
                    return;
                }
            }
            Console.WriteLine($"Khong tim thay ma hoa don {maHoaDon}");
        }
        static void HienThiDanhSach()
        {
            
            Console.WriteLine("==========DANH SACH HOA DON==========");
            foreach (var hd in dsHoaDon)
            {
                Console.WriteLine($"Ma hoa don: {hd.MaHoaDon}");
                Console.WriteLine($"Ma hoa don: {hd.NgayPhatHanh}");
                Console.WriteLine($"Ma hoa don: {hd.SoTien}");
                Console.WriteLine($"Ma hoa don: {hd.NguoiMua}");
                Console.WriteLine($"Ma hoa don: {hd.NgayMua}");
            }
            Console.WriteLine("======================================");
        }
        static void TimKiemHoaDon()
        {
            Console.WriteLine("Nhap hoa don can tim kiem");
            string maHoaDon = Console.ReadLine();
            bool timThay = false;
            foreach (var hd in dsHoaDon)
            {
                if (hd.MaHoaDon == maHoaDon)
                {
                    Console.WriteLine($"Ma hoa don: {hd.MaHoaDon}");
                    Console.WriteLine($"Ma hoa don: {hd.NgayPhatHanh}");
                    Console.WriteLine($"Ma hoa don: {hd.SoTien}");
                    Console.WriteLine($"Ma hoa don: {hd.NguoiMua}");
                    Console.WriteLine($"Ma hoa don: {hd.NgayMua}");
                    timThay = true;
                }
            }
            if (!timThay)
            {
                Console.WriteLine($"Khong tim thay ma hoa don {maHoaDon}");
            }

        }
        static void Main(string[] args)
        {
            int luachon;

            do
            {
                Menu();
                Console.Write("Nhap vao lua chon cua ban: ");
                luachon = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (luachon)
                {
                    case 1:
                        NhapHoaDonMoi();
                        break;
                    case 2:
                        XoaHoaDon();
                        break;
                    case 3:
                        SuaHoaDon();
                        break;
                    case 4:
                        HienThiDanhSach();
                        break;
                    case 5:
                        TimKiemHoaDon();
                        break;
                    case 6:
                        Console.WriteLine("Ket thuc chuong trinh");
                        break;
                    default:
                        Console.WriteLine("Lua chon khong hop le");
                        break;
                }
                Console.WriteLine();
            } while (luachon != 6);
            Console.ReadKey();
        }
    }
}
