using Ejercicio.EFU.Data;

namespace Ejercicio.EF.Logic
{
    public class BaseLogic
    {
        protected readonly NorthwindContext _northwindContext;

        public BaseLogic()
        {
            _northwindContext = new NorthwindContext();
        }
    }
}