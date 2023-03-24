using System.Collections.Generic;

namespace Ejercicio.EFU.Logic
{
    public interface ILogic<Categories>
    {
        List<Categories> GetAll();
        Categories GetOne(int id);
        Categories Add(Categories newEntity);
        Categories Update(Categories updatedEntity, int id);
        void Delete(int id);
    }
}