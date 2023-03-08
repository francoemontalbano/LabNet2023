using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public class DivisionException
    {
        public string Division(int dividendo)
        {
            try
            {
                int resultado = dividendo / 0;
                return ("El resultado de la division es de: " + resultado);
            }
            catch (DivideByZeroException ex)
            {
                throw (ex);
            }
        }
    }
}