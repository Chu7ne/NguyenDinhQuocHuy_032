using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2
{
    class ChuNhat
    {
        private double Rong, Dai;
        public ChuNhat(double Rong, double Dai)
        {
            this.Rong = Rong;
            this.Dai = Dai;
        }
        public virtual double TinhChuVi()
        {
            return 2 * (Rong + Dai);
        }
        public virtual double tinhDienTich()
        {
            return Rong * Dai;
        }
        public void Xuat()
        {
            Console.WriteLine("Chieu Rong: " + Rong);
            Console.WriteLine("Chieu Dai: " + Dai);
            Console.WriteLine("Dien Tich: " + tinhDienTich());
            Console.WriteLine("Chu vi: " + TinhChuVi());
        }
    }
    class Vuong : ChuNhat
    {
        public Vuong(double canh) : base(canh, canh) { }
        public virtual double tinhcanh()
        {
            return TinhChuVi() / 4;
        }
        public virtual void Xuat()
        {
            Console.WriteLine("Canh hinh vuong" + tinhcanh());
            Console.WriteLine("Dien tich:" + tinhDienTich());
            Console.WriteLine("Chu Vi:" + TinhChuVi());
        }
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Nhap chieu dai hinh chu nhat:");
                double daiCN = double.Parse(Console.ReadLine());

                Console.WriteLine("Nhap chieu rong hinh chu nhat");
                double rongCN = double.Parse(Console.ReadLine());

                Console.WriteLine("Nhap canh hinh vuong:");
                double canhvuong = double.Parse(Console.ReadLine());

                ChuNhat cn = new ChuNhat(daiCN, rongCN);
                Vuong vuong = new Vuong(canhvuong);

                Console.WriteLine("\n Thong tin Hinh Chu Nhat:");
                cn.Xuat();

                Console.WriteLine("\n Thong tin hinh vuong:");
                vuong.Xuat();

                Console.ReadLine();
            }
        }
    }
}
