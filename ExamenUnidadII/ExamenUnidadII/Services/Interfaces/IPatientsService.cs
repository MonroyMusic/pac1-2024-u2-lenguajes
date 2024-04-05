using ExamenUnidadII.Dtos.Patients;

namespace ExamenUnidadII.Services.Interfaces
{
    public interface IPatientsService
    {
        Task<ResponseDto<PatientDto>> CreateAsync(PatientDto model);
        Task<ResponseDto<List<PatientDto>>> GetListAsync(string searchTerm = "");
        Task<ResponseDto<PatientDto>> GetOneByIdAsync(Guid id);
    }
}