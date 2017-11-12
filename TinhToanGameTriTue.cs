using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuongQuocTroChoi
{
    public class TinhToanGameTriTue
    {
        public  double  so1, so2;
        public int dau;
        public string Dau(int dau)
        {
            if (dau == 0)
                return "+";
            else if (dau == 1)
                return "-";
            else if (dau == 2)
                return "x";
            else
                return "/";
        }
        public double ketQuaDung()
        {
            string daulayduoc = Dau(dau);
            if (daulayduoc == "+")
                return so1 + so2;
            if (daulayduoc == "-")
                return so1 - so2;
            if (daulayduoc == "x")
                return so1 * so2;
            if (daulayduoc == "/")
                return so1 / so2;
            return 0;
        }
    }
}
