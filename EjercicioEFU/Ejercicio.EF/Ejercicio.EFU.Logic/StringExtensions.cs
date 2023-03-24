using System;

namespace Ejercicio.EFU.Logic
{
    public static class StringExtensions

    {
        public static bool IsBetweenOneAndSix(this string str)
        {
            int num;
            bool isNumeric = int.TryParse(str, out num);
            return isNumeric && num >= 1 && num <= 6;
        }

        public static string ValidarCampo(string mensaje, Func<string, bool> validacion)
        {
            while (true)
            {
                Console.WriteLine(mensaje);
                string input = Console.ReadLine();

                if (!string.IsNullOrEmpty(input) && validacion(input.Trim()))
                {
                    return input.Trim();
                }
                else
                {
                    Console.WriteLine("El valor ingresado no es válido.");
                }
            }
        }
    }
}