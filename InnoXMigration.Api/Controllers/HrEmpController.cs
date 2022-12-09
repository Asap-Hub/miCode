using InnoXMigration.Application.Command.HrEmpCommands.CreateCommand;
using InnoXMigration.Application.Command.HrEmpCommands.DeleteCommand;
using InnoXMigration.Application.Command.HrEmpCommands.FindDataCommand;
using InnoXMigration.Application.Command.HrEmpCommands.GetAllDataCommand;
using InnoXMigration.Application.Command.HrEmpCommands.GetDataCommand;
using InnoXMigration.Application.Command.HrEmpCommands.UpdateCommand;
using InnoXMigration.Application.Dtos.HrEmpDto;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace InnoXMigration.Api.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]

    public class HrEmpController : Controller
    {
        private readonly IMediator _mediator;
        private readonly ILogger<HrEmpController> _logger;

        public HrEmpController(IMediator mediator, ILogger<HrEmpController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet("{ID:int}", Name = ("GetHrEmpByID"))]
        public async Task<IActionResult> GetHrEmpByID([FromRoute] int ID)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var getData = await _mediator.Send(new GetHrEmpCommand { Id = ID });
                if (getData == null)
                {

                    return NotFound($"no data found with ID:: {ID}. enter a valid ID");
                }
                return Ok(getData);
            }
            catch (Exception)
            {

                _logger.LogError(message: $"Unbale to get Data with the passed ID");
                return null ;
            }
           

        }
        [HttpPost]
        [Route("")]
        public async Task<IActionResult> CreateHrEmp([FromBody] TblHrEmpDto HrEmpDto)
        { 
        
        if(!ModelState.IsValid)
            {
                return View("Created:", HrEmpDto);
            }
            try
            {
                var CreateDataMediatR = await _mediator.Send(new CreateHrEmpCommand { HrEmpDto = HrEmpDto });
                return NoContent();
            }
            catch (Exception)
            {

                _logger.LogError(message:"Unable to Create Hr Employee");
                return null;
            }
                    
        }

        [HttpGet] 
        public async Task<IActionResult> GetAllHrEmp() {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {

                var GetDataMediatR = await _mediator.Send(new GetAlltHrEmpCommand());
                return Ok(GetDataMediatR);
            }
            catch (Exception)
            {

              _logger.LogError(message: "Unable to get all Data");
                return null;
            }
        }

        [HttpDelete("{EmpkId:int}")]
        public async Task<int> DeleteHrEmp([FromRoute] int EmpkId) {

            try
            {
                var DeleteData = await _mediator.Send(new DeleteHrEmpCommand { EmpkId = EmpkId });
                _logger.LogError(message: "Data Deleted");
                return DeleteData;
            }
            catch (Exception)
            {

                _logger.LogError(message: "Unable to Delete!.");
                return 0;
            }
            
        }


        [HttpPut("{EmpkId:int}")]
        public async Task<int> UpdateHrEmp([FromRoute, FromBody] int EmpkId, UpdateHrEmpDto updateHrEmpDto)
        {
            try
            {
                var UpdateData = await _mediator.Send(new UpdateHrEmpCommand { EmpkId = EmpkId, updateHrEmpDto = updateHrEmpDto });
                return UpdateData;
            }
            catch (Exception)
            {

                _logger.LogError(message: "Unable to Update Data");
                return 0;
            }

        }

       // 200
        [HttpGet]
        [Route("find")]
        public async Task<ActionResult> FindEmployee([FromQuery] bool? active = null, [FromQuery] bool? visible = null, [FromQuery] string? staffNo = null)
        {
            if (active != null)
            {
                var filteredList = await _mediator.Send(new FindDataHrCommand { FilterKey = EmployeeFilter.EmpActive, FilterValue = active });
                return Ok(new { count = filteredList.Count(), data = filteredList.ToList()});
            }

            if (visible != null)
            {
                var filteredList = await _mediator.Send(new FindDataHrCommand { FilterKey = EmployeeFilter.EmpVisible, FilterValue = visible });
                return Ok(new { count = filteredList.Count(), data = filteredList.ToList()});
            }

            if (staffNo != null && staffNo.Length > 0)
            {
                var filteredList = await _mediator.Send(new FindDataHrCommand { FilterKey = EmployeeFilter.StaffNo, FilterValue = staffNo });
                return Ok(new { count = filteredList.Count(), data = filteredList.ToList() });
            }


            var employees = await _mediator.Send(new FindDataHrCommand { });
            return Ok(new { count = employees.Count(), data = employees });
        }
    }
}
