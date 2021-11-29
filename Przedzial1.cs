using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Przedzial1 : IPrzedzialy
            {
        public int Id => 1;
        public string Name => "From -10 to 10";

        public decimal rangeFrom()
        {
            return -10;
        }

        public decimal rangeTo()
        {
            return 10;
        }
    }
}
