using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3
{
    internal class Drob
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Drob (double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
        public double Chislo()
        {
            return A*(B/C);
        }
    }
}
