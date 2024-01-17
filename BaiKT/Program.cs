using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1
{
    class Nhanvien
    {
        public string HoTen { get; set; }
        public int SoNgayCong { get; set; }
        public int SoNgayLamThem { get; set; }
        public string XepLoai { get; set; }
        public string BoPhan { get; set; }
        public Nhanvien() { }
        public Nhanvien(string hoTen, int soNgayCong, int soNgayLamThem, string xepLoai, string boPhan)
        {
            HoTen = hoTen;
            SoNgayCong = soNgayCong;
            SoNgayLamThem = soNgayLamThem;
            XepLoai = xepLoai;
            BoPhan = boPhan;
        }
        public double TinhLuong()
        {
            double phanTramTang = (BoPhan == "TrucTiep") ? 3.0 : 2.0;
            double luongMotNgay = 100000;

            return (SoNgayCong + SoNgayLamThem * (phanTramTang / 100)) * luongMotNgay;
        }
        public double TinhThuNhap()
        {
            switch (XepLoai)
            {
                case "a":
                    return 1.5 * TinhLuong();
                case "b":
                    return 1.2 * TinhLuong();
                case "c":
                    return TinhLuong();
                default:
                    return 0;
            }
        }
        public void InThongTin()
        {
            Console.WriteLine("Ho Ten: ",HoTen);
            Console.WriteLine("Bo Phan: ",BoPhan);
            Console.WriteLine("Thu Nhap: {0} VND ",TinhThuNhap());
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Nhanvien nv = new Nhanvien();
            Console.Write("Nhap Ho Ten: ");
            nv.HoTen = Console.ReadLine();
            Console.Write("Nhap So Ngay Cong: ");
            nv.SoNgayCong = int.Parse(Console.ReadLine());
            Console.Write("Nhap So Ngay Lam Them: ");
            nv.SoNgayLamThem = int.Parse(Console.ReadLine());
            Console.Write("Nhap Xep Loai (A/B/C): ");
            nv.XepLoai = Console.ReadLine();
            Console.Write("Nhap Bo Phan (TrucTiep/GianTiep): ");
            nv.BoPhan = Console.ReadLine();
            nv.InThongTin();
            Nhanvien nv1 = new Nhanvien("Tran Van Teo", 21, 6, "C", "TrucTiep");
            nv1.InThongTin();
        }
    }
}