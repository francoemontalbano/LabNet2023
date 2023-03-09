using System;

namespace EjercicioMEU
{
    public class DivisionExceptionTwo
    {
        public string Dividir(int dividendo, int divisor)
        {
            try
            {
                int resultado = dividendo / divisor;
                return ($"El resultado de la division es {resultado}");
            }
            catch (DivideByZeroException ex)
            {
                throw (ex);
            }
        }
    }
}