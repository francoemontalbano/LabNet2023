using System.ComponentModel.DataAnnotations;

namespace Ejercicio.EFU.WA.Models
{
    public class ShippersViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre de la compañía es obligatorio")]
        [StringLength(25, ErrorMessage = "El nombre de la compañía  no puede tener más de 25 caracteres")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "El campo 'CompanyName' solo acepta letras y espacios.")]
        public string CompanyName { get; set; }

        [Required(ErrorMessage = "El número de la compañía es obligatorio.")]
        [StringLength(14, ErrorMessage = "El número de la compañía no puede tener más de 14 caracteres.")]
        [RegularExpression(@"^\(\d{3}\) \d{3}-\d{4}$", ErrorMessage = "El campo 'Phone' debe tener el formato (###) ###-####.")]
        public string Phone { get; set; }

        public bool GetOrdersByShipperId { get; set; }
    }
}