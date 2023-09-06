using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class XeNgoaiThanh:QuanLyChuyenXe
    {
        string noiDen;

        public string NoiDen
        {
            get { return noiDen; }
            set { noiDen = value; }
        }
        int soNgayDiDuoc;

        public int SoNgayDiDuoc
        {
            get { return soNgayDiDuoc; }
            set { soNgayDiDuoc = value; }
        }
        public XeNgoaiThanh()
        {

        }
        public XeNgoaiThanh(string maSoChuyen, string hoTenTaiXe, int soXe,string noiDen, int soNgayDiDuoc):base(maSoChuyen,hoTenTaiXe,soXe)
        {
            this.noiDen = noiDen;
            this.soNgayDiDuoc = soNgayDiDuoc;
        }
        public void XuatNgoaiThanh()
        {
            base.XuatQL();
            Console.WriteLine("Noi den: {0}, So ngay di duoc: {1}", noiDen, soNgayDiDuoc);
        }
    }
}
