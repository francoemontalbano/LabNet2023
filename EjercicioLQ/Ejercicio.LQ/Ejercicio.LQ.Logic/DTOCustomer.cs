using System;

namespace Ejercicio.LQ.Logic
{
    public class DTOCustomer 
    {
        public string CustomerID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public DateTime? OrderDate { get; set; }
        public int OrderID { get; set; }
        public int OrderCount { get; set; }
    }
}