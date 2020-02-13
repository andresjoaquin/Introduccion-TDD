using IntroTdd.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace IntroTdd.Test.Unit
{
    public class CuentaBancariaTest
    {
        [Fact]
        public void RetornaElSaldoActual()
        {
            //Arrange
            CuentaBancaria cuenta = new CuentaBancaria(100);

            //Act
            var saldo = cuenta.SaldoActual;

            //Assert
            Assert.Equal(100, saldo);
        }

        [Fact]
        public void ActualizaElSaldoAlRealizarUnDeposito()
        {
            //Arrange
            CuentaBancaria cuenta = new CuentaBancaria(100);

            //Act
            cuenta.Depositar(50);

            //Assert
            Assert.Equal(150, cuenta.SaldoActual);
        }

        [Fact]
        public void ProduceUnErrorAlRealizarUnDepositoPorMontoCero()
        {
            //Arrange
            CuentaBancaria cuenta = new CuentaBancaria(100);

            //Act y Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => cuenta.Depositar(0));
        }
    }
}
