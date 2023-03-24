using Ejercicio.EFU.Entities;
using Ejercicio.EFU.Logic;
using System.Collections.Generic;
using System.Linq;

namespace Ejercicio.EF.Logic
{
    public class CategoriesLogic : BaseLogic, ILogic<Categories>
    {
        public List<Categories> GetAll()
        {
            return _northwindContext.Categories.ToList();
        }

        public Categories GetOne(int id)
        {
            var category = _northwindContext.Categories.FirstOrDefault(c => c.CategoryID == id);
            if (category == null)
            {
                return null;
            }
            return category;
        }

        public Categories Add(Categories newCategory)
        {
            _northwindContext.Categories.Add(newCategory);
            _northwindContext.SaveChanges();
            return newCategory;
        }

        public Categories Update(Categories updatedCategory, int id)
        {
            Categories categoryToUpdate = GetOne(id);
            categoryToUpdate.CategoryName = updatedCategory.CategoryName;
            categoryToUpdate.Description = updatedCategory.Description;
            _northwindContext.SaveChanges();
            return categoryToUpdate;
        }

        public void Delete(int id)
        {
            Categories categoryToDelete = GetOne(id);
            _northwindContext.Categories.Remove(categoryToDelete);
            _northwindContext.SaveChanges();
        }

        public bool GetProductsByCategoryId(int categoryId)
        {
            return _northwindContext.Products.Any(c => c.CategoryID == categoryId);
        }

        
    }
}