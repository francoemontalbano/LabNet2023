using Ejercicio.EF.Logic;
using Ejercicio.EFU.Entities;
using Ejercicio.EFU.MVC.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Ejercicio.EFU.MVC.Controllers
{
    public class CategoriesController : Controller
    {
        public ActionResult Index()
        {
            var categoriesLogic = new CategoriesLogic();
            var categorias = categoriesLogic.GetAll();

            List<CategoriesViewModel> categoriesViews = (from categoria in categorias
                                                         select new CategoriesViewModel()
                                                         {
                                                             Id = categoria.CategoryID,
                                                             CategoryName = categoria.CategoryName,
                                                             Description = categoria.Description
                                                         }).ToList();
            return View(categoriesViews);
        }

        public ActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Agregar(CategoriesViewModel categoria)
        {
            if (ModelState.IsValid)
            {
                var categoriesLogic = new CategoriesLogic();
                var categoriaEntity = new Categories() { Description = categoria.Description, CategoryName = categoria.CategoryName };
                categoriesLogic.Add(categoriaEntity);
                return RedirectToAction("Index");
            }
            return View(categoria);
        }

        public ActionResult Eliminar(int id)
        {
            CategoriesLogic categoriesLogic = new CategoriesLogic();
            bool categoriaTieneProductos = categoriesLogic.GetProductsByCategoryId(id);

            var modelo = new CategoriesViewModel()
            {
                CategoriaTieneProductos = categoriaTieneProductos
            };

            if (categoriaTieneProductos)
            {
                TempData["ErrorMessage"] = "No se puede eliminar esta categoría porque tiene productos relacionados. Intentelo nuevamente";
                return RedirectToAction("Index");
            }

            categoriesLogic.Delete(id);

            return RedirectToAction("Index");
        }

        public ActionResult Editar(int id)
        {
            CategoriesLogic categoriesLogic = new CategoriesLogic();
            CategoriesViewModel model = new CategoriesViewModel();

            var entity = categoriesLogic.GetOne(id);
            model.Id = entity.CategoryID;
            model.CategoryName = entity.CategoryName;
            model.Description = entity.Description;

            return View(model);
        }

        [HttpPost]
        public ActionResult Editar(CategoriesViewModel categories, int id)
        {
            if (ModelState.IsValid)
            {
                CategoriesLogic categoriesLogic = new CategoriesLogic();
                var categoriaAModificar = new Categories() { CategoryID = categories.Id, CategoryName = categories.CategoryName, Description = categories.Description };
                categoriesLogic.Update(categoriaAModificar, id);
                return RedirectToAction("Index");
            }
            return View(categories);
        }
    }
}