using EjercicioMEU.Ejercicio3;
using System;

namespace EjercicioMEU
{
    public class ExceptionThree
    {
        public void FetchException()
        {
            try
            {
                Logic logic = new Logic();

                Console.WriteLine("Excepcion ");

                logic.LogicException();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Mensaje de la excepción: {ex.Message}");
                Console.WriteLine($"Tipo de la excepción: {ex.GetType()}\n");
            }
        }
    }
}