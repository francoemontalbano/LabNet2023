using System;

namespace EjercicioPOO
{
    public class Taxi : Transporte
    {
        public override void Avanzar()
        {
            Console.WriteLine("\nEl taxi está avanzando con " + Pasajeros + " pasajeros.");

        }

        public override void Detenerse()
        {
            Console.WriteLine("\nEl taxi se está deteniendo con " + Pasajeros + " pasajeros.\n");
        }
    }
}