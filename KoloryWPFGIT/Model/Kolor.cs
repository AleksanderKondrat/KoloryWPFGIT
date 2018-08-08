using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoloryWPFGIT.Model
{
    public class Kolor
    {
        public byte A { get; set; }
        public byte R { get; set; }
        public byte G { get; set; }
        public byte B { get; set; }

        public Kolor(byte a, byte r, byte g, byte b) {
            this.A = a;
            this.R = r;
            this.G = g;
            this.B = b;
        }

        public Kolor(byte r, byte g, byte b)
        {
            this.A = 255;
            this.R = r;
            this.G = g;
            this.B = b;
        }

    }
}
