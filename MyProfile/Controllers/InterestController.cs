using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProfile.Models;
using MyProfile.Repositories;
using System.Collections.Generic;

namespace MyProfile.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InterestController : ControllerBase
    {
        private readonly IInterestRepository _interestRepo;
        public InterestController(IInterestRepository interestRepo)
        {
            _interestRepo = interestRepo;
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<Interest> interests = _interestRepo.GetAll();
            return Ok(interests);
        }
    }
}
