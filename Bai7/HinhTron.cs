using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    class HinhTron:ToaDo
    {
        ToaDo tam;

        internal ToaDo Tam
        {
            get { return tam; }
            set { tam = value; }
        }
        double banKinh;

        public double BanKinh
        {
            get { return banKinh; }
            set { banKinh = value; }
        }
        public double TinhChuVi()
        {
            return 2 * Math.PI * banKinh;
        }
        public double TinhDienTich()
        {
            return banKinh * banKinh * Math.PI;
        }
        public HinhTron()
        {
            Tam = new ToaDo();
            banKinh = 10.5;
        }
        public HinhTron(ToaDo tam, double banKinh)
        {
            this.tam = tam;
            this.banKinh = banKinh;                                   
        }
        public void xuat()
        {
           
            Console.WriteLine("Chu vi la: {0}, Dien tich la: {1}",TinhChuVi(),TinhDienTich());
        }
    }
}
