using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProfile.Models;
using MyProfile.Repositories;
using System.Collections.Generic;

namespace MyProfile.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkController : ControllerBase
    {
        private readonly IWorkRepository _workRepo;
        public WorkController(IWorkRepository workRepo)
        {
            _workRepo = workRepo;
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<Work> works= _workRepo.GetAll();
            return Ok(works);
        }
    }
}
