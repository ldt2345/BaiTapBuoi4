using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class Program1
    {
        static void Main(string[] args)
        {
            XeNoiThanh xnt = new XeNoiThanh();
            XeNgoaiThanh xngt = new XeNgoaiThanh();
            xnt.Xuat();
            xngt.XuatNgoaiThanh();
            Console.ReadKey();
        }
    }
}
