using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testCalc = Calculadora.Util;

namespace Calculadora.Nunit
{
    [TestFixture]
    public class CalculadoraTests
    {
        private testCalc.Calculadora _calc;

        [TestFixtureSetUp]
        public void SetUp()
        {
            _calc = new testCalc.Calculadora();
        }

        [Test]
        public void TestSomar()
        {
            //testCalc.Calculadora calc = new testCalc.Calculadora();
            Assert.AreEqual(4, _calc.Somar(2, 2));
        }

        [Test]
        public void TestSubtrair()
        {
            //testCalc.Calculadora calc = new testCalc.Calculadora();
            Assert.AreEqual(0, _calc.Subtrair(2, 2));
        }

        [Test]
        [Ignore("Metodo Não Implementado")]
        public void TestException()
        {
            testCalc.Calculadora calc = new testCalc.Calculadora(2);
            calc.Somar(1, 1);
        }

        [TestFixtureTearDown]
        public void TerDown()
        {
            _calc = null;
        }

        [Test]
        [Ignore("Metodo Não Implementado")]
        public void c()
        {
        }

        [Test]
        [Ignore("Metodo Não Implementado")]
        public void TestDividir()
        {
        }
    }
}
