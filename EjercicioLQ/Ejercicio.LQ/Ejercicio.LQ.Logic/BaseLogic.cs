using Ejercicio.LQ.Data;

namespace Ejercicio.LQ.Logic
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