namespace ExamenUnidadII.Dtos.Patients
{
    public class PatientDto
    {

        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Genre { get; set; }

        public string Weight { get; set; }

        public string Height { get; set; }

        public double IMC { get; set; } 

    }
}
