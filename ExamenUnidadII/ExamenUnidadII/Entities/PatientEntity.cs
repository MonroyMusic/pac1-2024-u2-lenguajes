using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamenUnidadII.Entities
{

    [Table("data", Schema = "people")]
    public class PatientEntity
    {

        [Column("id")]
        [Key]
        public Guid Id { get; set; }

        [Column("name")]
        [Required]
        public string Name { get; set; }

        [Column("genre")]
        [Required]
        public string Genre{ get; set; }

        [Column("weight")]
        [Required]
        public double Weight { get; set; }

        [Column("height")]
        [Required]
        public int Height { get; set; }

        [Column("imc")]
        [Required]
        public double IMC { get; set; }


    }
}
