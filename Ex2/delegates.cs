using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    public delegate double Func(double x);
    public class delegates
    {
        public double F1(double x)
        {
            return x * x - 50 * x + 10;
        }
        public double F2(double x)
        {
            return x * x - 30 * x + 20;
        }
        public double F3(double x)
        {
            return x * x - 15 * x + 94;
        }
    }
}
