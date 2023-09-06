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
            X = x;
            Y = y;
        }
        public ToaDo()
        {
        }
        public override string ToString()
        {

            return ("Ten: " + ten + "Toa do X:" + x + "Toa do Y: " + y);
        }
    }
}
