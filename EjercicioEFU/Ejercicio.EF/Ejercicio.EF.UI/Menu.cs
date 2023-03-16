using Ejercicio.EF.Logic;
using Ejercicio.EFU.Data;
using Ejercicio.EFU.Entities;
using Ejercicio.EFU.Logic;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Globalization;
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
            ShippersLogic shippersLogic = new ShippersLogic();
            Validaciones validaciones = new Validaciones();
            bool aux = true;
            

            while (aux)
            {

                Console.WriteLine("Menú: ");
                Console.WriteLine("1. Consultar un empleado por ID");
                Console.WriteLine("2. Consultar todos los empleados");
                Console.WriteLine("3. Consultar un shipper por ID");
                Console.WriteLine("4. Consultar todos los shippers");
                Console.WriteLine("5. ABM");
                Console.WriteLine("6. Salir\n");
                //int n = int.Parse(Console.ReadLine());

                string n = Console.ReadLine();

                if (validaciones.RealizarValidacionMenu(n))
                {
                    switch (int.Parse(n))
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
                            Console.WriteLine("\nIngrese el ID del Shipper");
                            int idShip = int.Parse(Console.ReadLine());
                            var shipper = shippersLogic.GetOne(idShip);
                            Console.WriteLine($"\nID: {shipper.ShipperID}," +
                                              $"\nNombre de compañia: {shipper.CompanyName}," +
                                              $"\nNombre de contacto: {shipper.Phone}\n"
                            );
                            break;

                        case 4:
                            var shippers = shippersLogic.GetAll();
                            foreach (var shipe in shippers)
                            {
                                Console.WriteLine($"\nID: {shipe.ShipperID}," +
                                                  $"\nNombre de compañia : {shipe.CompanyName}," +
                                                  $"\nNombre de contacto : {shipe.Phone}\n"
                                );
                            }
                            break;

                        case 5:
                            Console.WriteLine("Ingrese una opcion: \n\n" +
                                                "\n1)Ingresar empleado" +
                                                "\n2)Modificar empleado por ID" +
                                                "\n3)Eliminar empleado por ID" +
                                                "\n\n4)Ingresar shipper" +
                                                "\n5)Modificar shipper por ID" +
                                                "\n6)Eliminar shipper por ID" +
                                                "\n\n7)Volver");


                            int n2 = int.Parse(Console.ReadLine());
                            switch (n2)
                            {
                                case 1:
                                    Employees nuevoEmpleado = new Employees();
                                    Console.WriteLine("Ingrese el apellido del empleado");
                                    string apellido = Console.ReadLine();
                                    if (validaciones.RealizarValidacionLetras(apellido))
                                    {
                                        nuevoEmpleado.LastName = apellido;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Solo se permiten letras. Intentelo nuevamente");
                                        break;
                                    }

                                    Console.WriteLine("Ingrese el Nombre del empleado");
                                    string nombre = Console.ReadLine();
                                    if (validaciones.RealizarValidacionLetras(apellido))
                                    {
                                        nuevoEmpleado.FirstName = nombre;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Solo se permiten letras. Intentelo nuevamente");
                                        break;
                                    }

                                    Console.WriteLine("Ingrese el rol del empleado");
                                    string rol = Console.ReadLine();
                                    if (validaciones.RealizarValidacionLetras(rol))
                                    {
                                        nuevoEmpleado.Title = rol;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Solo se permiten letras. Intentelo nuevamente");
                                        break;
                                    }
                                    
                                    Console.WriteLine("Ingrese el telefono del empleado");
                                    string telefono = Console.ReadLine();
                                    if (validaciones.RealizarValidacionNumeros(telefono))
                                    {
                                        nuevoEmpleado.HomePhone = telefono;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Solo se permiten números. Intentelo nuevamente");
                                        break;
                                    }

                                    Console.WriteLine("Ingrese la fecha de cumpleaños del empleado");
                                    string fecha = Console.ReadLine();
                                    if (validaciones.RealizarValidacionFechas(fecha))
                                    {
                                        nuevoEmpleado.BirthDate = DateTime.ParseExact(fecha, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Solo se permiten datos de fecha. Intentelo con este formato dd/mm/yyyy");
                                        break;
                                    }
                                    
                                    Console.WriteLine("Ingrese el región del empleado");
                                    string region = Console.ReadLine();
                                    if (validaciones.RealizarValidacionLetras(region))
                                    {
                                        nuevoEmpleado.Region = region;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Solo se permiten letras. Intentelo nuevamente");
                                        break;
                                    }
                                    
                                    Console.WriteLine("Ingrese el dirección del empleado");
                                    string direccion = Console.ReadLine();
                                    if (validaciones.RealizarValidacionLetrasYNumeros(direccion))
                                    {
                                        nuevoEmpleado.Address = direccion;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Solo se permiten letras y/o números. Intentelo nuevamente");
                                        break;
                                    }
                                    
                                    Console.WriteLine("Ingrese la ciudad del empleado");
                                    string ciudad = Console.ReadLine();
                                    if (validaciones.RealizarValidacionLetras(ciudad))
                                    {
                                        nuevoEmpleado.City = ciudad;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Solo se permiten letras. Intentelo nuevamente");
                                        break;
                                    }
                                    
                                    Console.WriteLine("Ingrese el país del empleado");
                                    string pais = Console.ReadLine();
                                    if (validaciones.RealizarValidacionLetras(pais))
                                    {
                                        nuevoEmpleado.Country = pais;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Solo se permiten letras. Intentelo nuevamente");
                                        break;
                                    }
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
                                        string apellidoEdit = Console.ReadLine();
                                        if (validaciones.RealizarValidacionLetras(apellidoEdit))
                                        {
                                            empleadoAEditar.LastName = apellidoEdit;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Solo se permiten letras. Intentelo nuevamente");
                                            break;
                                        }
                                        
                                        Console.WriteLine("Ingrese el nombre del empleado");
                                        string nombreEdit = Console.ReadLine();
                                        if (validaciones.RealizarValidacionLetras(nombreEdit))
                                        {
                                            empleadoAEditar.FirstName = nombreEdit;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Solo se permiten letras. Intentelo nuevamente");
                                            break;
                                        }

                                        Console.WriteLine("Ingrese el rol del empleado");
                                        string rolEdit = Console.ReadLine();
                                        if (validaciones.RealizarValidacionLetras(rolEdit))
                                        {
                                            empleadoAEditar.Title = rolEdit;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Solo se permiten letras. Intentelo nuevamente");
                                            break;
                                        }

                                        
                                        Console.WriteLine("Ingrese el telefono del empleado");
                                        string telefonoEdit = Console.ReadLine();
                                        if (validaciones.RealizarValidacionNumeros(telefonoEdit))
                                        {
                                            empleadoAEditar.HomePhone = telefonoEdit;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Solo se permiten números. Intentelo nuevamente");
                                            break;
                                        }

                                        Console.WriteLine("Ingrese la fecha de cumpleaños del empleado");
                                        string fechaEdit = Console.ReadLine();
                                        if (validaciones.RealizarValidacionFechas(fechaEdit))
                                        {
                                            empleadoAEditar.BirthDate = DateTime.Parse(Console.ReadLine());
                                        }
                                        else
                                        {
                                            Console.WriteLine("Solo se permiten datos de fecha. Intentelo con este formato dd/mm/yyyy");
                                            break;
                                        }

                                        Console.WriteLine("Ingrese la región del empleado");
                                        string regionEdit = Console.ReadLine();
                                        if (validaciones.RealizarValidacionLetras(regionEdit))
                                        {
                                            empleadoAEditar.Region = regionEdit;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Solo se permiten letras. Intentelo nuevamente");
                                            break;
                                        }
                                        
                                        Console.WriteLine("Ingrese la dirección del empleado");
                                        string direccionEdit = Console.ReadLine();
                                        if (validaciones.RealizarValidacionLetrasYNumeros(direccionEdit))
                                        {
                                            empleadoAEditar.Address = direccionEdit;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Solo se permiten letras y/o números. Intentelo nuevamente");
                                            break;
                                        }

                                        Console.WriteLine("Ingrese la ciudad del empleado");
                                        string ciudadEdit = Console.ReadLine();
                                        if (validaciones.RealizarValidacionLetras(ciudadEdit))
                                        {
                                            empleadoAEditar.City = ciudadEdit;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Solo se permiten letras. Intentelo nuevamente");
                                            break;
                                        }

                                        Console.WriteLine("Ingrese el país del empleado");
                                        string paisEdit = Console.ReadLine();
                                        if (validaciones.RealizarValidacionLetras(paisEdit))
                                        {
                                            empleadoAEditar.Country = paisEdit;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Solo se permiten letras. Intentelo nuevamente");
                                            break;
                                        }

                                        _northwindContext.SaveChanges();
                                        Console.WriteLine("El empleado se ha actualizado correctamente.");
                                    }
                                    break;

                                case 3:
                                    Console.WriteLine("Ingrese ID del empleado a eliminar: ");
                                    int idEmpleadoAEliminar = int.Parse(Console.ReadLine());

                                    Employees empleadoAEliminar = _northwindContext.Employees.FirstOrDefault(e => e.EmployeeID == idEmpleadoAEliminar);

                                    if (empleadoAEliminar == null)
                                    {
                                        Console.WriteLine("No se encontró ningún shipper con ese ID. Intentelo nuevamente");
                                    }
                                    else
                                    {
                                        employeesLogic.Delete(idEmpleadoAEliminar);
                                        Console.WriteLine("Empleado borrado correctamente.");
                                    }
                                    
                                    break;

                                case 4:
                                    Shippers nuevoShipper = new Shippers();
                                    Console.WriteLine("Ingrese el nombre de la compañia: ");
                                    string company = Console.ReadLine();
                                    if (validaciones.RealizarValidacionLetras(company))
                                    {
                                        nuevoShipper.CompanyName = company;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Solo se permiten letras. Intentelo nuevamente");
                                        break;
                                    }
                                    
                                    Console.WriteLine("Ingrese el telefono de la compañia: ");
                                    string phone = Console.ReadLine();
                                    if (validaciones.RealizarValidacionNumeros(phone))
                                    {
                                        nuevoShipper.Phone = phone;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Solo se permiten números. Intentelo nuevamente");
                                        break;
                                    }
                                    _northwindContext.Shippers.Add(nuevoShipper);
                                    _northwindContext.SaveChanges();

                                    break;

                                case 5:
                                    Console.WriteLine("Ingrese ID del shipper a editar: ");
                                    int idShipperAModificar = int.Parse(Console.ReadLine());

                                    Shippers shipperAEditar = _northwindContext.Shippers.FirstOrDefault(s => s.ShipperID == idShipperAModificar);

                                    if (shipperAEditar == null)
                                    {
                                        Console.WriteLine("No se encontró ningún shipper con ese ID.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ingrese el nombre de la compañia");
                                        string companyEdit = Console.ReadLine();
                                        if (validaciones.RealizarValidacionLetras(companyEdit))
                                        {
                                            shipperAEditar.CompanyName = companyEdit;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Solo se permiten letras. Intentelo nuevamente");
                                            break;
                                        }
                                        
                                        Console.WriteLine("Ingrese el número de la compañia");
                                        string phoneEdit = Console.ReadLine();
                                        if (validaciones.RealizarValidacionNumeros(phoneEdit))
                                        {
                                            shipperAEditar.Phone = phoneEdit;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Solo se permiten números. Intentelo nuevamente");
                                            break;
                                        }

                                        _northwindContext.SaveChanges();
                                        Console.WriteLine("El shipper se actualizó correctamente");
                                    }

                                    break;


                                case 6:
                                    Console.WriteLine("Ingrese ID del shipper a eliminar: ");
                                    int idShipperAEliminar = int.Parse(Console.ReadLine());

                                    Shippers shipperAEliminar = _northwindContext.Shippers.FirstOrDefault(s => s.ShipperID == idShipperAEliminar);

                                    if (shipperAEliminar == null)
                                    {
                                        Console.WriteLine("No se encontró ningún shipper con ese ID.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ingrese el ID del shipper a eliminar: ");
                                        ShippersLogic shippersLogic1 = new ShippersLogic();
                                        shippersLogic1.Delete(idShipperAEliminar);
                                        Console.WriteLine("El shipper se eliminó correctamente");
                                    }


                                    //Console.WriteLine("Ingrese el ID del shipper a eliminar: ");
                                    //int idShipperAEliminar = int.Parse(Console.ReadLine());
                                    //ShippersLogic shippersLogic1 = new ShippersLogic();
                                    //shippersLogic1.Delete(idShipperAEliminar);
                                    //Console.WriteLine("El shipper se eliminó correctamente");
                                    break;

                            }
                            break;

                        case 6:
                            aux = false;
                            Console.WriteLine("Presione una tecla para salir del programa");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("\nSolo se permiten números del 1 al 6. Intentelo nuevamente\n");
                }
            }
        }
    }
}
