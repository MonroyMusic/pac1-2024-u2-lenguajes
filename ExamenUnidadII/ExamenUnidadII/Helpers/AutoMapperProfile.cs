using AutoMapper;
using ExamenUnidadII.Dtos.Patients;
using ExamenUnidadII.Entities;

namespace ExamenUnidadII.Helpers
{
    public class AutoMapperProfile : Profile
    {

        public AutoMapperProfile()
        {

            MapsForPatient();

        }

        private void MapsForPatient()
        {

            CreateMap<PatientEntity, PatientDto>();
            CreateMap<PatientCreateDto, PatientEntity>();

        }

    }
}
