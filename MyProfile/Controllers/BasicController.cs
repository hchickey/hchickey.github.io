using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProfile.Models;
using MyProfile.Repositories;
using System.Collections.Generic;

namespace MyProfile.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasicController : ControllerBase
    {
        private readonly IBasicRepository _basicRepo;
        public BasicController(IBasicRepository basicRepo)
        {
            _basicRepo = basicRepo;
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<Basic> basics = _basicRepo.GetAll();
            return Ok(basics);
        }
    }
}
