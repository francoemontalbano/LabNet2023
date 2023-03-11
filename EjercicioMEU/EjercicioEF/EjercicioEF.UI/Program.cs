using EjercicioEF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEF.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Products");

            ProductLogic productlogic = new ProductLogic();

            var products = productlogic.GetAll();

            foreach (var prod in productlogic.GetAll())
            {
                Console.WriteLine(prod.ProductName);
            }

            Console.ReadLine();
        }
    }
}
