using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void CalculerTest()
        {
            int x = 2; // TODO : initialisez à une valeur appropriée 

            int expected = 2;
            int actual;

            actual = Test.App3_ProgramAccessor.Calculer(x);

            Assert.AreEqual(expected, actual, "App3.Program.Calculer n\'a pas retourné la valeur attendue.");
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }
    }
}