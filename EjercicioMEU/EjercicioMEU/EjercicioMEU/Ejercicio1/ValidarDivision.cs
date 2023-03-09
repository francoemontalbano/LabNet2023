using Ejercicio1;
using System;

namespace EjercicioMEU.Ejercicio1
{
    public class ValidarDivision
    {
        public void RealizarValidicionDivision()
        {
            try
            {
                DivisionException divisionException = new DivisionException();

                bool esNumerico = false;

                while (!esNumerico)
                {
                    Console.WriteLine("Ingrese el numero que será dividido por cero");
                    string dividendo = Console.ReadLine();

                    esNumerico = true;
                    foreach (char c in dividendo)
                    {
                        if (c < '0' || c > '9')
                        {
                            esNumerico = false;
                            break;
                        }
                    }

                    if (!esNumerico)
                    {
                        Console.WriteLine("Sólo se aceptan valores númericos. Intentalo nuevamente");
                    }

                    divisionException.Division(Int32.Parse(dividendo));
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
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