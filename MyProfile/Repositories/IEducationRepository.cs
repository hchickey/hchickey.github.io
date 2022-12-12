using MyProfile.Models;
using System.Collections.Generic;

namespace MyProfile.Repositories
{
    public interface IEducationRepository
    {
        List<Education> GetAll();
    }
}