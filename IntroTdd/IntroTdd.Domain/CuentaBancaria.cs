using System;
using System.Collections.Generic;
using System.Text;

namespace IntroTdd.Domain
{
    public class CuentaBancaria
    {
        private Decimal saldoInicial;

        public CuentaBancaria(Decimal saldoInicial)
        {
            this.saldoInicial = saldoInicial;
        }

        public Decimal SaldoActual => this.saldoInicial;
    }
}
