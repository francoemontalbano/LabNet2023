using System;

namespace EjercicioMEU.Ejercicio4
{
    public class LogicCustom : Exception
    {
        public void RealizarExcepcion(string mensajePersonalizado)
        {
            try
            {
                throw new ExceptionFour(mensajePersonalizado);
            }
            catch (ExceptionFour ex)
            {
                Console.WriteLine($"{ex.Message}\n");
            }
        }
    }
}