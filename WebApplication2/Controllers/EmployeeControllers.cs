using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using WebApplication2.Models;
using WebApplication2.Services;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeControllers : Controller
    {
        public  IEmp _EmpService;

        public EmployeeControllers(IEmp EmpService)
        {
            _EmpService = EmpService;

        }
        [HttpGet("GetEmp")]
        public async Task<ActionResult<List<Emp>>> Get()
        {
            return Ok(_EmpService.GetEmp());
        }

        [HttpGet("GetById/{id}")]
        public async Task<ActionResult<Emp>> GetById(int id)
        {

            return Ok(_EmpService.GetById(id));
        }

        [HttpPost("NewEmp")]

        public async Task<ActionResult<List<Emp>>> CreateTeacher(Emp newEmp)
        {

            return Ok(_EmpService.CreateEmp(newEmp));
        }

        [HttpPut("Update")]
        public async Task<ActionResult<List<Emp>>> UpdateTeacher(Emp updateEmp)
        {

            return Ok(_EmpService.UpdateEmp(updateEmp));
        }

        [HttpDelete("Delete/{id}")]
        public async Task<ActionResult<List<Emp>>> DeleteEmp(int id)
        {

            return Ok(_EmpService.DeleteEmp(id));
        }

    }
}
