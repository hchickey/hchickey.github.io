using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProfile.Models;
using MyProfile.Repositories;
using System.Collections.Generic;

namespace MyProfile.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillController : ControllerBase
    {
        private readonly ISkillRepository _skillRepo;
        public SkillController(ISkillRepository skillRepo)
        {
            _skillRepo = skillRepo;
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<Skill> skills = _skillRepo.GetAll();
            return Ok(skills);
        }
    }
}
