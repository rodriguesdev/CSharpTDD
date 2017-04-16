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
        [Test]
        public void TestSomar()
        {
            testCalc.Calculadora calc = new testCalc.Calculadora();
            Assert.AreEqual(4, calc.Somar(2, 2));
        }

        [Test]
        public void TestSubtrair()
        {
            testCalc.Calculadora calc = new testCalc.Calculadora();
            Assert.AreEqual(0, calc.Subtrair(2, 2));
        }

        //[Test]
        //public void TestMultiplicar()
        //{
        //}

        //[Test]
        //public void TestDividir()
        //{
        //}
    }
}
