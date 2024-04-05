using System.ComponentModel.DataAnnotations;

namespace ExamenUnidadII.Entities
{
    public class ParientCreateDto
    {

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "El {0} es requerido")]
        public string Name { get; set; }

        [Display(Name = "Genero")]
        [Required(ErrorMessage = "El {0} es requerido")]
        public string Genre { get; set; }

        [Display(Name = "Peso")]
        [Required(ErrorMessage = "El {0} es requerido")]
        public string  Weight { get; set; }

        [Display(Name = "Estatura")]
        [Required(ErrorMessage = "La {0} es requerido")]
        public string Height { get; set; }
    }
}
