﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BancoWeb.ViewModel
{
    public class ContaCorrenteViewModel
    {
        public int ID { get; set; }
        public int Agencia { get; set; }
        public int NumeroConta { get; set; }
        public double Saldo { get; set; }
    }
}