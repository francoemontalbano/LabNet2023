using Ejercicio.EF.Logic;
using Ejercicio.EFU.Data;
using Ejercicio.EFU.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEF.UI
{
    public class Menu
    {
        NorthwindContext _northwindContext = new NorthwindContext();


        public void GetMenu()
        {
            EmployeesLogic employeesLogic = new EmployeesLogic();
            CustomersLogic customersLogic = new CustomersLogic();
            bool aux = true;


            while (aux)
            {
                Console.WriteLine("Menú: ");
                Console.WriteLine("1. Consultar un empleado por ID");
                Console.WriteLine("2. Consultar todos los empleados");
                Console.WriteLine("3. Consultar un customer por ID");
                Console.WriteLine("4. Consultar todos los customers");
                Console.WriteLine("5. ABM");
                Console.WriteLine("6. Salir\n");
                int n = int.Parse(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        Console.WriteLine("\nIngrese el ID del empleado");
                        int idEmplo = int.Parse(Console.ReadLine());
                        var empleado = employeesLogic.GetOne(idEmplo);
                        Console.WriteLine($"\nID:{empleado.EmployeeID}," +
                                          $"\nApellido: {empleado.LastName}," +
                                          $"\nNombre: {empleado.FirstName}," +
                                          $"\nRol: {empleado.Title}," +
                                          $"\nTelefono: {empleado.HomePhone}," +
                                          $"\nFecha de cumpleaños: {empleado.BirthDate}," +
                                          $"\nRegión: {empleado.Region}," +
                                          $"\nDirección: {empleado.Address}," +
                                          $"\nCiudad: {empleado.City}" +
                                          $"\nPaís: {empleado.Country}\n"

                                              );
                        break;

                    case 2:
                        var empleados = employeesLogic.GetAll();
                        foreach (var emple in empleados)
                        {
                            Console.WriteLine($"\nID: {emple.EmployeeID}," +
                                              $"\nApellido : {emple.LastName}," +
                                              $"\nNombre : {emple.FirstName}," +
                                              $"\nRol : {emple.Title}," +
                                              $"\nTelefono : {emple.HomePhone}," +
                                              $"\nFecha de cumpleaños: {emple.BirthDate}," +
                                              $"\nRegion: {emple.Region}," +
                                              $"\nDirección: {emple.Address}," +
                                              $"\nCiudad: {emple.City}," +
                                              $"\nPaís: {emple.Country}\n"

                                              );
                        }
                        break;

                    case 3:
                        Console.WriteLine("\nIngrese el ID del customer");
                        int idCusto = int.Parse(Console.ReadLine());
                        var customer = customersLogic.GetOne(idCusto);
                        Console.WriteLine($"\nID: {customer.CustomerID}," +
                                          $"\nNombre de compañia: {customer.CompanyName}," +
                                          $"\nNombre de contacto: {customer.ContactName}\n"
                        );
                        break;

                    case 4:
                        var customers = customersLogic.GetAll();
                        foreach (var custo in customers)
                        {
                            Console.WriteLine($"\nID: {custo.CustomerID}," +
                                              $"\nNombre de compañia : {custo.CompanyName}," +
                                              $"\nNombre de contacto : {custo.ContactName}\n"
                            );
                        }
                        break;

                    case 5:
                        Console.WriteLine("Ingrese una opcion: \n\n" +
                                            "\n1)Ingresar empleado" +
                                            "\n2)Modificar empleado por ID" +
                                            "\n3)Eliminar empleado por ID" +
                                            "\n\n4)Ingresar customer" +
                                            "\n5)Modificar customer por ID" +
                                            "\n6)Eliminar customer por ID" +
                                            "\n\n7)Volver");


                        int n2 = int.Parse(Console.ReadLine());
                        switch (n2)
                        {
                            case 1:
                                Employees nuevoEmpleado = new Employees();
                                Console.WriteLine("Ingrese el apellido del empleado");
                                nuevoEmpleado.LastName = Console.ReadLine();
                                Console.WriteLine("Ingrese el Nombre del empleado");
                                nuevoEmpleado.FirstName = Console.ReadLine();
                                Console.WriteLine("Ingrese el rol del empleado");
                                nuevoEmpleado.Title = Console.ReadLine();
                                Console.WriteLine("Ingrese el telefono del empleado");
                                nuevoEmpleado.HomePhone = Console.ReadLine();
                                Console.WriteLine("Ingrese la fecha de cumpleaños del empleado");
                                nuevoEmpleado.BirthDate = DateTime.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese el región del empleado");
                                nuevoEmpleado.Region = Console.ReadLine();
                                Console.WriteLine("Ingrese el dirección del empleado");
                                nuevoEmpleado.Address = Console.ReadLine();
                                Console.WriteLine("Ingrese la ciudad del empleado");
                                nuevoEmpleado.City = Console.ReadLine();
                                Console.WriteLine("Ingrese el país del empleado");
                                nuevoEmpleado.Country = Console.ReadLine();
                                _northwindContext.Employees.Add(nuevoEmpleado);
                                _northwindContext.SaveChanges();

                                break;



                            case 2:
                                Console.WriteLine("Ingrese el ID del empleado a editar:");
                                int idEmpleadoAEditar = int.Parse(Console.ReadLine());


                                Employees empleadoAEditar = _northwindContext.Employees.FirstOrDefault(e => e.EmployeeID == idEmpleadoAEditar);

                                if (empleadoAEditar == null)
                                {
                                    Console.WriteLine("No se encontró ningún empleado con ese ID.");
                                }
                                else
                                {
                                    Console.WriteLine("Ingrese el apellido del empleado");
                                    empleadoAEditar.LastName = Console.ReadLine();
                                    Console.WriteLine("Ingrese el nombre del empleado");
                                    empleadoAEditar.FirstName = Console.ReadLine();
                                    Console.WriteLine("Ingrese el rol del empleado");
                                    empleadoAEditar.Title = Console.ReadLine();
                                    Console.WriteLine("Ingrese el telefono del empleado");
                                    empleadoAEditar.HomePhone = Console.ReadLine();
                                    Console.WriteLine("Ingrese la fecha de cumpleaños del empleado");
                                    empleadoAEditar.BirthDate = DateTime.Parse(Console.ReadLine());
                                    Console.WriteLine("Ingrese la región del empleado");
                                    empleadoAEditar.Region = Console.ReadLine();
                                    Console.WriteLine("Ingrese la dirección del empleado");
                                    empleadoAEditar.Address = Console.ReadLine();
                                    Console.WriteLine("Ingrese la ciudad del empleado");
                                    empleadoAEditar.City = Console.ReadLine();
                                    Console.WriteLine("Ingrese el país del empleado");
                                    empleadoAEditar.Country = Console.ReadLine();

                                    _northwindContext.SaveChanges();
                                    Console.WriteLine("El empleado se ha actualizado correctamente.");
                                }
                                break;

                            case 3:
                                Console.WriteLine("Ingrese el ID del empleado a eliminar:");
                                int idEmpleadoAEliminar = int.Parse(Console.ReadLine());
                                EmployeesLogic employeesLogic1 = new EmployeesLogic();
                                employeesLogic1.Delete(idEmpleadoAEliminar);
                                Console.WriteLine("Empleado borrado correctamente");
                                break;

                            case 4:
                                

                            case 5:
                               
                                break;


                            case 6:

                                break;
                                
                        }
                        break;

                    case 6:
                        Console.WriteLine("Presione una tecla para salir del programa");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;




                }
            }
        }
    }
}
