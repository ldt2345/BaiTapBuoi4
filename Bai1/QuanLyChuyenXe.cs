using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class QuanLyChuyenXe
    {
        string maSoChuyen;

        public string MaSoChuyen
        {
            get { return maSoChuyen; }
            set { maSoChuyen = value; }
        }
        string hoTenTaiXe;

        public string HoTenTaiXe
        {
            get { return hoTenTaiXe; }
            set { hoTenTaiXe = value; }
        }
        int soXe;

        public int SoXe
        {
            get { return soXe; }
            set { soXe = value; }
        }
        double doanhThu;

        public double DoanhThu
        {
            get { return doanhThu; }
            set { doanhThu = value; }
        }
       public QuanLyChuyenXe()
        {

        }
        public QuanLyChuyenXe(string maSoChuyen, string hoTenTaiXe, int soXe)
       {
           this.maSoChuyen = maSoChuyen;
           this.hoTenTaiXe = hoTenTaiXe;
           this.soXe = soXe;
       }
        public void XuatQL()
        {
            Console.WriteLine("Ma so chuyen : {0}, Ho ten tai xe: {1}, So xe: {2}", maSoChuyen, hoTenTaiXe, soXe);
        }
    }
}