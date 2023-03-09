using System;

namespace EjercicioMEU
{
    public class ExceptionFour : Exception
    {
        public ExceptionFour(string mensajePersonalizado) : base($"Mensaje personalizado de la excepción: {mensajePersonalizado}")
        {
        }
    }
}