using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Transporte> transportes = new List<Transporte>();

            for (int i = 1; i < 6; i++)
            {
                Omnibus omnibus = new Omnibus();
                Console.WriteLine($"Ingrese la cantidad de pasajeros que tiene el omnibus {i}:");
                try
                {
                    omnibus.Pasajeros = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Error: el valor ingresado no es un número válido.");
                    i--; // para permitir que el usuario ingrese un valor válido para el mismo vehículo nuevamente
                    continue;
                }
                transportes.Add(omnibus);
                Console.WriteLine("El omnibus " + i + " tiene " + omnibus.Pasajeros + " pasajeros");
                omnibus.Avanzar();
                omnibus.Detenerse();
            }

            for (int i = 1; i < 6; i++)
            {
                Taxi taxi = new Taxi();

                Console.WriteLine($"Ingrese la cantidad de pasajeros que tiene el taxi {i}:");
                try
                {
                    taxi.Pasajeros = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("\nError: el valor ingresado no es un número válido.");
                    i--; 
                    continue;
                }
               
                transportes.Add(taxi);
                Console.WriteLine("\nEl taxi " + i + " tiene " + taxi.Pasajeros + " pasajeros");
                taxi.Avanzar();
                taxi.Detenerse();
            }

            Console.ReadKey();
        }
    }
}