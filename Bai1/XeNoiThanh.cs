using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class XeNoiThanh
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
        int soTuyen;

        public int SoTuyen
        {
            get { return soTuyen; }
            set { soTuyen = value; }
        }
        double soKM;

        public double SoKM
        {
            get { return soKM; }
            set { soKM = value; }
        }
        double doanhThu;

        public double DoanhThu
        {
            get { return doanhThu; }
            set { doanhThu = value; }
        }
        public XeNoiThanh(string maSoChuyen, string hoTenTaiXe, int soXe, int soTuyen, double soKM, double doanhThu)
        {
            this.maSoChuyen = maSoChuyen;
            this.hoTenTaiXe = hoTenTaiXe;
            this.soKM = soKM;
            this.soXe = soXe;
            this.soTuyen = soTuyen;
            this.doanhThu = doanhThu;
        }
        public double TinhTongDoanhThu()
        {

        }
    }
}
