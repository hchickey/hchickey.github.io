using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProfile.Models;
using MyProfile.Repositories;
using System.Collections.Generic;

namespace MyProfile.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VolunteerController : ControllerBase
    {
        private readonly IVolunteerRepository _volunteerRepo;
        public VolunteerController(IVolunteerRepository volunteerRepo)
        {
            _volunteerRepo = volunteerRepo;
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<Volunteer> volunteers = _volunteerRepo.GetAll();
            return Ok(volunteers);
        }
    }
}
