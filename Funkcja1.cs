﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
   public class Funkcja1 : IFunction

    {

        public int Id => 1;

        public string Name => "y=2x+2x2";

        public decimal GetY(decimal x)
        {
            return 2 * x + 2 * x * x;


        }
    }
}