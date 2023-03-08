using Ejercicio1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                DivisionException divisionException = new DivisionException();

                Console.WriteLine("Ingrese el numero que será dividido por cero");

                int dividendo = int.Parse(Console.ReadLine());

                divisionException.Division(dividendo);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("\nFin de la operacion. Presione una tecla para salir");

            }

            Console.ReadKey();
        }
    }
}