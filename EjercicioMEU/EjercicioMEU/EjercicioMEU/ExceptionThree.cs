using EjercicioMEU.Ejercicio3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
                Console.WriteLine($"Se ha producido una excepción: {ex.Message}");
                Console.WriteLine($"Tipo de excepción: {ex.GetType()}\n");
            }

        }
    }
}
