using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Ejercicio1.Tests
{
    [TestClass()]
    public class DivisionExceptionTests
    {
        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivisionTest()
        {
            DivisionException divisionException = new DivisionException();
            int dividendo = 10;
            divisionException.Division(dividendo);

            Assert.ThrowsException<DivideByZeroException>(() => divisionException.Division(dividendo));
        }
    }
}