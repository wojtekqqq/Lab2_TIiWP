using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Przedzial3 : IPrzedzialy
    {
        public int Id => 3;
        public string Name => "From -5 to 0";

        public decimal rangeFrom()
        {
            return -5;
        }

        public decimal rangeTo()
        {
            return 0;
        }
    }
}
