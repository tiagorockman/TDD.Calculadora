using System;
using Xunit;
using TDD.calculadora;

namespace XUnitCalculadoraTest
{
    public class CalculadoraTest
    {

        /// <summary>
        /// Possiveis Testes
        /// 2 inteiros
        /// 2 negativos
        /// 1 inteiro e 1 negativo
        /// </summary>

        [Fact]
        public void Soma()
        {
            int resultado = Calculadora.Soma(2,2);
            int esperado = 4;
            Assert.Equal(esperado, resultado);
        }

        [Fact]
        public void Soma2()
        {
            int resultado = Calculadora.Soma(-2, -2);
            int esperado = -4;
            Assert.Equal(esperado, resultado);
        }

        [Fact]
        public void Soma3()
        {
            int resultado = Calculadora.Soma(-2, 1);
            int esperado = -1;
            Assert.Equal(esperado, resultado);
        }
    }
}
