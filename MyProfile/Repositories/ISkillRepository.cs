using MyProfile.Models;
using System.Collections.Generic;

namespace MyProfile.Repositories
{
    public interface ISkillRepository
    {
        List<Skill> GetAll();
    }
}