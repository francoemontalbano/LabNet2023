using System.Text.RegularExpressions;

namespace Ejercicio.LQ.Logic
{
    public class ValidacionMenu
    {
        public bool RealizarValidacionMenu(string menu)
        {
            string pattern = @"^([1-9]|1[0-3])$";
            return Regex.IsMatch(menu, pattern);
        }
    }
}