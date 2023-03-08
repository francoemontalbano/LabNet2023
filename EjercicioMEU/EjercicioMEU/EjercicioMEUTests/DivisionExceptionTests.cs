using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Tests
{
    [TestClass()]
    public class DivisionExceptionTests
    {
        [TestMethod()]
        public void DivisionTest()
        {
            DivisionException divisionException = new DivisionException();
            int dividendo = 10;
            divisionException.Division(dividendo);
        }
    }
}