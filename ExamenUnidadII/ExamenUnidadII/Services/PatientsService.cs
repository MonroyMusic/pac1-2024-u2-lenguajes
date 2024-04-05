using AutoMapper;
using ExamenUnidadII.Database;
using ExamenUnidadII.Dtos;
using ExamenUnidadII.Dtos.Patients;
using ExamenUnidadII.Entities;
using ExamenUnidadII.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ExamenUnidadII.Services
{
    public class PatientsService : IPatientsService
    {

        private readonly IMCDatabaseContext _dbContext;
        private readonly IMapper _mapper;

        public PatientsService(
            IMCDatabaseContext dbContext, 
            IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<ResponseDto<List<PatientDto>>> GetListAsync(string searchTerm = "")
        {

            var patientEntity = await _dbContext.Patient
                .Where( p => p.Name.Contains(searchTerm)).ToListAsync();

            var patientsDto = _mapper.Map<List<PatientDto>>(patientEntity);

            return new ResponseDto<List<PatientDto>>
            {

                Status = true,
                StatusCode = 200,
                Message = "Paciente ingresado correctamente",
                Data = patientsDto

            };

        }

        public async Task<ResponseDto<PatientDto>> GetOneByIdAsync(Guid id)
        {

            var patientEntity = await _dbContext.Patient.FirstOrDefaultAsync( p => p.Id == id);

            if (patientEntity == null)
            {

                return new ResponseDto<PatientDto>
                {
                    Status = true,
                    StatusCode = 404,
                    Message = $"Tarea {id} no encontrada."
                };

            }

            var patientDto = _mapper.Map<PatientDto>(patientEntity);

            return new ResponseDto<PatientDto>
            {
                Status = true,
                StatusCode = 200,
                Message = $"Paciente {patientDto.Id} encontrado.",
                Data = patientDto
            };

        }

        public async Task<ResponseDto<PatientDto>> CreateAsync(PatientCreateDto model)
        {

            var patientEntity = _mapper.Map<PatientEntity>(model);

            _dbContext.Patient.Add(patientEntity);
            await _dbContext.SaveChangesAsync();

            var patientDto = _mapper.Map<PatientDto>(patientEntity);

            return new ResponseDto<PatientDto>
            {
                Status = true,
                StatusCode = 201,
                Message = "Paciente ingresado correctamente",
                Data = patientDto
            };

        }

    }
}
