﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Spot
    {
        public int Id { get; set; }

        public string Spots { get; set; }

        public override string ToString()
        {
            return Spots;
        }
    }
}
