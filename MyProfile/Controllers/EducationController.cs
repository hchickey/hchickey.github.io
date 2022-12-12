using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProfile.Models;
using MyProfile.Repositories;
using System.Collections.Generic;

namespace MyProfile.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EducationController : ControllerBase
    {
        private readonly IEducationRepository _educationRepo;
        public EducationController(IEducationRepository educationRepo)
        {
            _educationRepo = educationRepo;
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<Education> educations= _educationRepo.GetAll();
            return Ok(educations);
        }
    }
}
