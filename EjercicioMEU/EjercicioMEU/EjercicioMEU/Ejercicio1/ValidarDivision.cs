using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio1;


namespace EjercicioMEU.Ejercicio1
{
    public class ValidarDivision
    {
        
            public void RealizarValidicionDivision()
            {
                try
                {
                    DivisionException divisionException = new DivisionException();

                    Console.WriteLine("Ingrese el numero que será dividido por cero");

                int dividendo;

                while (!int.TryParse(Console.ReadLine(), out dividendo))
                {
                    Console.WriteLine("\nDebe ingresar un numero válido. Intente nuevamente");
                }

                    divisionException.Division(dividendo);
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("\nFin de la operacion. Presione una tecla para salir \n");
                }
                Console.ReadKey();
            }
    }

}

