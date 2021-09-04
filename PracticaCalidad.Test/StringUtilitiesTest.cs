using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using PracticaCalidad;
namespace PracticaCalidad.Test
{
    class StringUtilitiesTest
    {
        [Test]
        public void casoprueba01()
        {
            var utils = new StringUtilities();
            int numeros = 1;
            var result = utils.Romano(numeros);
            Assert.AreEqual("I", result);
        }
        [Test]
        public void casoprueba02()
        {
            var utils = new StringUtilities();
            int numeros = 2;
            var result = utils.Romano(numeros);
            Assert.AreEqual("II", result);
        }
        [Test]
        public void casoprueba03()
        {
            var utils = new StringUtilities();
            int numeros = 1;
            var result = utils.Romano(numeros);
            Assert.AreEqual("I", result);
        }
        [Test]
        public void casoprueba04()
        {
            var utils = new StringUtilities();
            int numeros = 1;
            var result = utils.Romano(numeros);
            Assert.AreEqual("I", result);
        }
        [Test]
        public void casoprueba05()
        {
            var utils = new StringUtilities();
            int numeros = 1;
            var result = utils.Romano(numeros);
            Assert.AreEqual("I", result);
        }
        [Test]
        public void casoprueba06()
        {
            var utils = new StringUtilities();
            int numeros = 1;
            var result = utils.Romano(numeros);
            Assert.AreEqual("I", result);
        }
        [Test]
        public void casoprueba07()
        {
            var utils = new StringUtilities();
            int numeros = 4;
            var result = utils.Romano(numeros);
            Assert.AreEqual("IV", result);

        }

        [Test]
        public void casoprueba08()
        {
            var utils = new StringUtilities();
            int numeros = 100;
            var result = utils.Romano(numeros);
            Assert.AreEqual("C", result);
        }
        [Test]
        public void casoprueba09()
        {
            var utils = new StringUtilities();
            int numeros = 50;
            var result = utils.Romano(numeros);
            Assert.AreEqual("L", result);
        }
        [Test]
        public void casoprueba10()
        {
            var utils = new StringUtilities();
            int numeros = 30;
            var result = utils.Romano(numeros);
            Assert.AreEqual("XXX", result);
        }
        [Test]
        public void casoprueba11()
        {
            var utils = new StringUtilities();
            int numeros = 20;
            var result = utils.Romano(numeros);
            Assert.AreEqual("XX", result);
        }
        [Test]
        public void casoprueba12()
        {
            var utils = new StringUtilities();
            int numeros = 10;
            var result = utils.Romano(numeros);
            Assert.AreEqual("X", result);
        }
        [Test]
        public void casoprueba13()
        {
            var utils = new StringUtilities();
            int numeros = 5;
            var result = utils.Romano(numeros);
            Assert.AreEqual("V", result);
        }
        [Test]
    }
}
