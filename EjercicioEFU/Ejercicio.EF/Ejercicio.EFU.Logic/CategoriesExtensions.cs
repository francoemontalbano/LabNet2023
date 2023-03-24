using Ejercicio.EF.Logic;

namespace Ejercicio.EFU.Extensions
{
    public static class CategoriesExtensions
    {
        public static bool CategoriesExists(this CategoriesLogic categoriesLogic, int id)
        {
            return categoriesLogic.GetOne(id) != null;
        }
    }

}