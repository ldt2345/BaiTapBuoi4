using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    class ToaDo
    {
        string ten;

        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }
        float x;

        public float X
        {
            get { return x; }
            set { x = value; }
        }
        float y;

        public float Y
        {
            get { return y; }
            set { y = value; }
        }
        public ToaDo(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public ToaDo():this(5,5)
        {
            ten = "O";
        }
        public override string ToString()
        {

            return "Hinh tron co tam " + ten + "(" + x + ","  + y + ")";
        }
    }
}
