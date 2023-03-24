using Ejercicio.EF.Logic;

namespace Ejercicio.EFU.Logic
{
    public static class ShippersExtensions
    {
        public static bool ShippersExists(this ShippersLogic shippersLogic, int id)
        {
            return shippersLogic.GetOne(id) != null;
        }
    }
}