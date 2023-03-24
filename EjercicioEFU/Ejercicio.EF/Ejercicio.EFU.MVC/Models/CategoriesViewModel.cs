using System.ComponentModel.DataAnnotations;

namespace Ejercicio.EFU.MVC.Models
{
    public class CategoriesViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre de la categoría es obligatorio")]
        [StringLength(15, ErrorMessage = "El nombre de la categoría no puede tener más de 15 caracteres")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "El campo 'CategoryName' solo acepta letras y espacios.")]
        public string CategoryName { get; set; }

        [Required(ErrorMessage = "La descripción de la categoría es obligatoria")]
        [StringLength(100, ErrorMessage = "La descripción de la categoría no puede tener más de 100 caracteres")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "El campo 'CategoryName' solo acepta letras y espacios.")]
        public string Description { get; set; }

        public bool CategoriaTieneProductos { get; set; }
    }
}