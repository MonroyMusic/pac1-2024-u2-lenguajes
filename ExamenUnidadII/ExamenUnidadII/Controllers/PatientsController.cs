using Microsoft.AspNetCore.Http;
using ExamenUnidadII.Dtos.Patients;
using ExamenUnidadII.Entities;
using ExamenUnidadII.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using ExamenUnidadII.Dtos;

namespace ExamenUnidadII.Controllers
{

    [Route("api/patients")]
    [ApiController]
    public class PatientsController : ControllerBase
    {
        private readonly IPatientsService _patientsService;

        public PatientsController(
            IPatientsService patientsService) {

            _patientsService = patientsService;

        }

        [HttpGet]
        public async Task<ActionResult<ResponseDto<List<PatientDto>>>> GetAll(string searchterm = "")
        {

            var patientResponse = await _patientsService.GetListAsync(searchterm);

            return StatusCode(patientResponse.StatusCode, patientResponse);

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ResponseDto<PatientDto>>> GetOneById(Guid id)
        {
            var patientResponse = await _patientsService.GetOneByIdAsync(id);

            return StatusCode(patientResponse.StatusCode, patientResponse);
        }

        [HttpPost]
        public async Task<ActionResult<ResponseDto<PatientDto>>> Create([FromBody] PatientCreateDto model)
        {
            var patientResponse = await _patientsService.CreateAsync(model);

            return StatusCode(patientResponse.StatusCode, patientResponse);
        }

    }
}
