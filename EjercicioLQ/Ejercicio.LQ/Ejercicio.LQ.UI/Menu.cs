using Ejercicio.LQ.Logic;
using System;

namespace Ejercicio.LQ.UI
{
    public class Menu
    {
        public void GetMenu()
        {
            ProductLogic productLogic = new ProductLogic();
            CustomersLogic customersLogic = new CustomersLogic();
            ValidacionMenu validacionMenu = new ValidacionMenu();
            bool aux = true;

            while (aux)
            {
                Console.WriteLine("Menú: \n");
                Console.WriteLine("1. Ejercicio 1");
                Console.WriteLine("2. Ejercicio 2");
                Console.WriteLine("3. Ejercicio 3");
                Console.WriteLine("4. Ejercicio 4");
                Console.WriteLine("5. Ejercicio 5");
                Console.WriteLine("6. Ejercicio 6");
                Console.WriteLine("7. Ejercicio 7");
                Console.WriteLine("8. Ejercicio 8");
                Console.WriteLine("9. Ejercicio 9");
                Console.WriteLine("10. Ejercicio 10");
                Console.WriteLine("11. Ejercicio 11");
                Console.WriteLine("12. Ejercicio 12");
                Console.WriteLine("13. Ejercicio 13");
                Console.WriteLine("14. Salir\n");

                string n = Console.ReadLine();

                if (validacionMenu.RealizarValidacionMenu(n))
                {
                    switch (int.Parse(n))
                    {
                        case 1:
                            var customerObjeto = customersLogic.GetCustomers();

                            Console.WriteLine($"Nombre del cliente: {customerObjeto.ContactName}\nDirección del cliente: {customerObjeto.Address}\nCiudad del cliente: {customerObjeto.City}\nPaís del cliente: {customerObjeto.Country}\n");

                            break;

                        case 2:
                            var productosSinStock = productLogic.GetProductSinStock();

                            foreach (var productoSinStock in productosSinStock)
                            {
                                Console.WriteLine($"ID del producto: {productoSinStock.ProductID}\nNombre del producto: {productoSinStock.ProductName}\nUnidades en stock: {productoSinStock.UnitsInStock}\n");
                            }

                            break;

                        case 3:
                            var productosConStockMayorA3 = productLogic.GetProductConStockMayorA3();

                            foreach (var productoConStockTres in productosConStockMayorA3)
                            {
                                Console.WriteLine($"ID del producto: {productoConStockTres.ProductID}\nNombre del producto: {productoConStockTres.ProductName}\nUnidades en stock: {productoConStockTres.UnitsInStock}\nPrecio del producto: {productoConStockTres.UnitPrice}\n");
                            }

                            break;

                        case 4:

                            var customersRegionEnWa = customersLogic.GetCustomersRegionWA();

                            foreach (var customerEnRegionWa in customersRegionEnWa)
                            {
                                Console.WriteLine($"Nombre del cliente: {customerEnRegionWa.ContactName}\nDirección del cliente: {customerEnRegionWa.Address}\nCiudad del cliente: {customerEnRegionWa.City}\nPaís del cliente:  {customerEnRegionWa.Country}\n Region del cliente: {customerEnRegionWa.Region}\n");
                            }

                            break;

                        case 5:
                            var productoID = productLogic.GetProductConID789();
                            if (productoID == null)
                            {
                                Console.WriteLine("No se encontró un producto con ID 789\n");
                            }
                            else
                            {
                                Console.WriteLine("Producto encontrado: {0}, Categoría: {1}, Precio: {2}\n", productoID.ProductName, productoID.Categories.CategoryName, productoID.UnitPrice);

                            }
                            break;


                        case 6:
                            var customerNombresEnMYM = customersLogic.GetCustomersMYM();

                            foreach (var customersEnMYM in customerNombresEnMYM)
                            {
                                Console.WriteLine($"{customersEnMYM}");
                            }
                            break;

                        case 7:
                            var customerOrders = customersLogic.GetCustomersYOrders();

                            foreach (var customerOrder in customerOrders)
                            {
                                Console.WriteLine("ID del cliente: {0},  ID de la orden: {1}\n", customerOrder.CustomerID, customerOrder.OrderID);
                            }

                            break;

                        case 8:
                            var customerPrimerosTres = customersLogic.GetCustomersThree();

                            foreach (var customerTres in customerPrimerosTres)
                            {
                                Console.WriteLine("ID: {0}, Nombre de la compañia: {1}\n", customerTres.CustomerID, customerTres.CompanyName);

                            }
                            break;

                        case 9:
                            var productoPorNombre = productLogic.GetProductPorNombre();

                            foreach (var productoNombre in productoPorNombre)
                            {
                                Console.WriteLine($"Nombre del producto: {productoNombre.ProductName}");
                            }
                            break;

                        case 10:
                            var productoPorStockMayor = productLogic.GetProductPorStockMayor();

                            foreach (var productStock in productoPorStockMayor)
                            {
                                Console.WriteLine("ID del producto: {0}\nNombre del producto: {1}\nUnidades en stock: {2}\n", productStock.ProductID, productStock.ProductName, productStock.UnitsInStock);
                            }

                            break;

                        case 12:
                            var productoPrimerElemento = productLogic.GetProductPrimerElemento();

                            Console.WriteLine("ID del producto: {0}\nNombre del producto: {1}\nUnidades en stock: {2}\n", productoPrimerElemento.ProductID, productoPrimerElemento.ProductName, productoPrimerElemento.UnitsInStock);

                            break;

                        case 13:
                            var customerConOrdenes = customersLogic.GetCustomersOrdenesAsociadas();

                            foreach (var customerAsociada in customerConOrdenes)
                            {
                                Console.WriteLine("Nombre del cliente: {0}, Cantidad de ordenes: {1}\n", customerAsociada.ContactName, customerAsociada.OrderCount);
                            }
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("\nSolo se permiten números del 1 al 13. Intentelo nuevamente\n");
                }
            }
        }
    }
}