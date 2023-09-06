using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class XeNoiThanh:QuanLyChuyenXe
    {
        int soTuyen;

        public int SoTuyen1
        {
            get { return soTuyen; }
            set { soTuyen = value; }
        }
        int soKm;

        public int SoKm
        {
            get { return soKm; }
            set { soKm = value; }
        }
        public XeNoiThanh()
        {

        }
        public XeNoiThanh(string maSoChuyen, string hoTenTaiXe, int soXe,int soTuyen, int soKm):base(maSoChuyen,hoTenTaiXe,soXe)
        {
            this.soTuyen = soTuyen;
            this.soKm = soKm;
        }
        public void Xuat()
        {
            base.XuatQL();
            Console.WriteLine("So tuyen: {0}, So km di duoc: {1}", soTuyen, soKm);
        }
    }
}
