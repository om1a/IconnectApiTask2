using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using WebApplication2.Models;
using WebApplication2.Services;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CompanyControllers : Controller
    {
        public IComp _CompServiceService;

        public CompanyControllers(IComp companyService)
        {
            _CompServiceService = companyService;

        }
        [HttpGet("GetComp")]
        public async Task<ActionResult<List<Comp>>> Get()
        {
            return Ok(_CompServiceService.GetComp());
        }

        [HttpGet("GetById/{id}")]
        public async Task<ActionResult<Comp>> GetById(int id)
        {

            return Ok(_CompServiceService.GetById(id));
        }

        [HttpPost("NewComp")]

        public async Task<ActionResult<List<Comp>>> CreateComp(Comp newComp)
        {

            return Ok(_CompServiceService.CreateComp(newComp));
        }

        [HttpPut("Update")]
        public async Task<ActionResult<List<Comp>>> UpdateComp(Comp updateComp)
        {

            return Ok(_CompServiceService.UpdateComp(updateComp));
        }

        [HttpDelete("Delete/{id}")]
        public async Task<ActionResult<List<Comp>>> DeleteTeacher(int id)
        {

            return Ok(_CompServiceService.DeleteComp(id));
        }

    }
}
