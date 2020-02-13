using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroTdd.Web.Models
{
    public class Cuenta
    {
        public int Monto { get; set; }
        public int Saldo { get; set; }

        public Cuenta()
        {
            Monto = 0;
            Saldo = 0;
        }
    }
}
