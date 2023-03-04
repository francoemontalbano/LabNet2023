using System;

namespace EjercicioPOO
{
    public abstract class Transporte
    {
        private int pasajeros;

        public int Pasajeros
        {
            get { return pasajeros; }
            set { pasajeros = value; }
        }

        public abstract void Avanzar();
        public abstract void Detenerse();
    }
}