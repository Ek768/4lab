﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Gitara: Tovar
    {
        public string Vid_instrumenta { get; set; }
        public string Marka_instrumenta { get; set; }
        public DateTime Release_data { get; set; }

        public Gitara(Nomenklatura ID, double Price, string Vid_instrumenta, string Marka_instrumenta, DateTime Release_data) : base(ID, Price)
        {
            this.Vid_instrumenta = Vid_instrumenta;
            this.Marka_instrumenta = Marka_instrumenta;
            this.Release_data = Release_data;
        }
    }
}
