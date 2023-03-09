using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioMEU
{
    public class DivisionExceptionTwo
    {
        public string Dividir(int dividendo, int divisor) 
        {
			try
			{
				int resultado = dividendo / divisor;
                return ("El resultado de la division es " + resultado);
			}
			catch (DivideByZeroException ex) 
			{

				throw(ex);
			}
        }
    }
}
