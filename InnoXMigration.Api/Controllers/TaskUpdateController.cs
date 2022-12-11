using AutoMapper;
using InnoXMigration.Application.Command.TaskUpdateCommands.CreateTaskCommand;
using InnoXMigration.Application.Command.TaskUpdateCommands.DeleteTaskCommand;
using InnoXMigration.Application.Command.TaskUpdateCommands.GetAllCommand;
using InnoXMigration.Application.Command.TaskUpdateCommands.GetByIdCommand;
using InnoXMigration.Application.Command.TaskUpdateCommands.UpdateTaskCommand;
using InnoXMigration.Application.Dtos.TaskDto;
using InnoXMigration.Application.Interface.Task;
using InnoXMigration.Domain.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace InnoXMigration.Api.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class TaskUpdateController : Controller
    {
        private readonly IMediator _mediator;
        private readonly ILogger<TaskUpdateController> _logger;

        public TaskUpdateController(IMediator mediator, ILogger<TaskUpdateController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }


        [HttpGet("{ID:int}", Name = ("GetTaskUpdateByID"))]
        public async Task<IActionResult> GetTaskUpdateById([FromRoute] int ID) {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var GetData = await _mediator.Send(new GetTaskUpdateByIdCommand { Id = ID });
            if (GetData == null) {
                return NotFound();
            }
            return Ok(GetData);

        }

        [HttpGet]
        [Route("GetAllData")]
        public async Task<IActionResult> GetAllTask() {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var getAllData = await _mediator.Send(new GetAllDataCommand { });
            return Ok(getAllData);
        }

        [HttpPost]
        [Route("CreateTaskUpdate")]
        public async Task<IActionResult>CreateTastUpdate([FromBody] TaskUpdateDto taskUpdateDto) {

            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }
            var UpdatingData = await _mediator.Send(new CreateTaskUpdateCommand { TaskDto = taskUpdateDto });
           

            if (UpdatingData == null) {
                _logger.LogError(message: "Unable to create the passed Data");
            }
            return NoContent();

        }

        [HttpPut]
        [Route("Update")]
        public async Task<IActionResult> UpdateTaskUpdate([FromBody] UpdateTaskUpdateDto updateDto) {
            if (!ModelState.IsValid) {
                return View("Update", updateDto);
            }
            var UpdateData = await _mediator.Send(new UpdateTaskUpdateCommand { TaskDto = updateDto }); 
            return Ok(UpdateData);
        
        }

        [HttpDelete("{Id:int}")] 
        public async Task<IActionResult> DeleteTaskUpdate([FromRoute] int Id) { 
        
        //if(!ModelState.IsValid)
        //    {

        //        return BadRequest(ModelState);
        //    }

        var data = await _mediator.Send(new DeleteTaskUpdateCommand { Id= Id });  
            return Ok(data);    
        }

    }
}
