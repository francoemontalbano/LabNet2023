using System.Text.RegularExpressions;

namespace Ejercicio.EFU.Logic
{
    public class Validaciones
    {
        public bool RealizarValidacionMenu(string menu)
        {
            string pattern = @"^[1-6]$";
            return Regex.IsMatch(menu, pattern);
        }

        public bool RealizarValidacionLetras(string menu) 
        {
            string pattern = @"^[a-zA-ZñÑ\s]{2,50}$";
            return Regex.IsMatch(menu, pattern);
        }

        public bool RealizarValidacionNumeros(string menu)
        {
            string pattern = @"^[0-9]{1,9}(\.[0-9]{0,2})?$";
            return Regex.IsMatch(menu, pattern);
        }

        public bool RealizarValidacionFechas(string menu)
        {
            string pattern = @"^([0-2][0-9]|3[0-1])(\/|-)(0[1-9]|1[0-2])\2(\d{4})$";
            return Regex.IsMatch(menu, pattern);
        }

        public bool RealizarValidacionLetrasYNumeros(string menu)
        {
            string pattern = @"^.*(?=.*[0-9])(?=.*[a-zA-ZñÑ\s]).*$";
            return Regex.IsMatch(menu, pattern);
        }

    }


}