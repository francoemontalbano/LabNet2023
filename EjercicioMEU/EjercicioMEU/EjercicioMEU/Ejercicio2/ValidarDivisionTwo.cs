using System;

namespace EjercicioMEU
{
    public class ValidarDivisionTwo
    {
        public void RealizarValidacionDivisionTwo()
        {
            try
            {
                DivisionExceptionTwo divisionExceptionTwo = new DivisionExceptionTwo();

                Console.WriteLine("Ingrese el valor del divisor");

                int dividendo = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el valor del dividendo");

                int divisor = int.Parse(Console.ReadLine());

                Console.WriteLine(divisionExceptionTwo.Dividir(dividendo, divisor));
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"{ex.Message} \nMirar el celular mientras programas es como dividir por cero: un error");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"{ex.Message} Tenes que ingresar numeros ");
            }
            finally
            {
                Console.WriteLine("\nFin de la operacion. Presione una tecla para salir \n");
            }
            Console.ReadKey();
        }
    }
}