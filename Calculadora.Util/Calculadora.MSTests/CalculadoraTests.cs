using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TwCalc = Calculadora.Util;

namespace Calculadora.MSTests
{
    [TestClass]
    public class CalculadoraTests
    {
        private TwCalc.Calculadora _calc;

        [TestInitialize]
        public void SetUp()
        {
            _calc = new TwCalc.Calculadora();
        }

        [TestMethod]
        public void TestSomar()
        {
            Assert.AreEqual(4, _calc.Somar(2, 2));
        }

        [TestMethod]
        public void TestSubtrair()
        {
            Assert.AreEqual(0, _calc.Subtrair(2, 2));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestSomarComException()
        {
            TwCalc.Calculadora calc2 = new TwCalc.Calculadora(limiteMinimo: 2);
            calc2.Somar(1, 1);
        }

        [TestMethod]
        [Ignore]
        public void TestMultiplicar()
        {
        }

        [TestMethod]
        [Ignore]
        public void TestDividir()
        {
        }

        [TestCleanup]
        public void Cleanup()
        {
            _calc = null;
        }
    }
}
