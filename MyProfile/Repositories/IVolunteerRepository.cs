using MyProfile.Models;
using System.Collections.Generic;

namespace MyProfile.Repositories
{
    public interface IVolunteerRepository
    {
        List<Volunteer> GetAll();
    }
}