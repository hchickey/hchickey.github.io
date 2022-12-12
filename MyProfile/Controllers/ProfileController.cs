using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProfile.Models;
using MyProfile.Repositories;
using System.Collections.Generic;

namespace MyProfile.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        private readonly IProfileRepository _profileRepo;
        public ProfileController(IProfileRepository profileRepo)
        {
            _profileRepo = profileRepo;
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<Profile> profiles= _profileRepo.GetAll();
            return Ok(profiles);
        }
    }
}
