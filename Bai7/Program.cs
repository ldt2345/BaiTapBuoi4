using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("mucho gusto");
            HinhTron ht = new HinhTron();
            Console.WriteLine(ht.Tam);
            ht.xuat();
            Console.ReadKey();
        }
    }
}
