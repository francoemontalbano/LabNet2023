using Ejercicio1;
using EjercicioMEU.Ejercicio1;
using EjercicioMEU.Ejercicio3;
using System;

namespace EjercicioMEU.Menu
{
    public class Menu
    {
        public void GetMenu()
        {
            while (true)
            {
                Console.WriteLine("Menú: Seleccione un ejercicio");
                Console.WriteLine("1. Ejercicio 1");
                Console.WriteLine("2. Ejercicio 2");
                Console.WriteLine("3. Ejercicio 3");
                Console.WriteLine("4. Ejercicio 4");
                Console.WriteLine("5. Salir");


                string opcion = Console.ReadLine();
                int opcionSeleccionada = int.Parse(opcion);


                switch (opcionSeleccionada) 
                { 
                    case 1: 
                        Console.WriteLine($"Seleccionaste el ejercicio {opcionSeleccionada}\n");
                        ValidarDivision validarDivision = new ValidarDivision();
                        validarDivision.RealizarValidicionDivision();
                        break;
                    case 2: 
                        Console.WriteLine($"Seleccionaste el ejercicio {opcionSeleccionada}\n");
                        ValidarDivisionTwo validarDivisionTwo = new ValidarDivisionTwo();
                        validarDivisionTwo.RealizarValidacionDivisionTwo();
                        break;
                    case 3: 
                        Console.WriteLine($"Seleccionaste el ejercicio {opcionSeleccionada}\n");
                        ExceptionThree exceptionThree = new ExceptionThree();
                        exceptionThree.FetchException();
                        break;
                    case 4: 
                        Console.WriteLine($"Seleccionaste el ejercicio {opcionSeleccionada}\n");
                        break;
                    case 5: 
                        Console.WriteLine("Presione una tecla para salir del programa");
                        Console.ReadKey();
                        Environment.Exit(0);
                        return;
                    case 6: 
                        Console.WriteLine("Opción inválida");
                        break;
                }
            }
        }
    }
}