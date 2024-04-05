using System.ComponentModel.DataAnnotations;

namespace ExamenUnidadII.Dtos.Patients
{
    public class PatientCreateDto
    {
        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "El {0} es requerido.")]
        public string Name { get; set; }

        [Display(Name = "Genero")]
        [Required(ErrorMessage = "El {0} es requerida.")]
        public string Genre { get; set; }

        [Display(Name = "Peso")]
        [Required(ErrorMessage = "El {0} es requerida.")]
        public double Weight { get; set; }

        [Display(Name = "Estatura")]
        [Required(ErrorMessage = "La {0} es requerida.")]
        public int Height { get; set; }

        public double IMC { get; set; }

    }
}
