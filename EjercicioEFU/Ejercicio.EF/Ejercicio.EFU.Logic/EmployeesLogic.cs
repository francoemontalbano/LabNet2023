using Ejercicio.EFU.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ejercicio.EF.Logic
{
    public class EmployeesLogic : BaseLogic
    {
        public List<Employees> GetAll()
        {
            return _northwindContext.Employees.ToList();
        }

        public Employees GetOne(int id)
        {
            try
            {
                return _northwindContext.Employees.First(e => e.EmployeeID.Equals(id));
            }
            catch (InvalidOperationException ex)
            {
                throw new Exception("No se encontró ningún empleado con el ID proporcionado", ex);
            }
        }

        public Employees Add(Employees newEmployee)
        {
            _northwindContext.Employees.Add(newEmployee);
            _northwindContext.SaveChanges();
            return newEmployee;
        }

        public Employees Update(Employees newEmployee, int id)
        {
            Employees empleadoAModificar = GetOne(id);
            empleadoAModificar.LastName = newEmployee.LastName;
            empleadoAModificar.FirstName = newEmployee.FirstName;
            empleadoAModificar.Title = newEmployee.Title;
            empleadoAModificar.HomePhone = newEmployee.HomePhone;
            empleadoAModificar.BirthDate = newEmployee.BirthDate;
            empleadoAModificar.Region = newEmployee.Region;
            empleadoAModificar.Address = newEmployee.Address;
            empleadoAModificar.City = newEmployee.City;
            empleadoAModificar.Country = newEmployee.Country;
            _northwindContext.SaveChanges();
            return empleadoAModificar;
        }

        public void Delete(int id)
        {
            Employees empleadoAEliminar = GetOne(id);
            _northwindContext.Employees.Remove(empleadoAEliminar);
            _northwindContext.SaveChanges();
        }
    }
}