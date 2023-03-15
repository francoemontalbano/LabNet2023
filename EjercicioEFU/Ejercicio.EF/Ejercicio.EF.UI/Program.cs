using Ejercicio.EFU.Entities;
using Ejercicio.EF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEF.UI
{
    public class Program
    {
        static void Main(string[] args)
        {

            Menu menu = new Menu();
            menu.GetMenu();
            Console.ReadLine();
        }
    }
}
