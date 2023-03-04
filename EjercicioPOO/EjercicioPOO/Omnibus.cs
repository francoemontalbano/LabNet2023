using System;

namespace EjercicioPOO
{
    public class Omnibus : Transporte
    {
        public override void Avanzar()
        {
            Console.WriteLine("\nEl ómnibus está avanzando con " +  Pasajeros + " pasajeros.");
        }
        public override void Detenerse()
        {
            Console.WriteLine("\nEl ómnibus se está deteniendo con " + Pasajeros + " pasajeros.\n");
        }
    }
}