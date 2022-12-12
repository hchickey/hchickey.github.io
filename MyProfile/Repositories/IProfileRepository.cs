using MyProfile.Models;
using System.Collections.Generic;

namespace MyProfile.Repositories
{
    public interface IProfileRepository
    {
        List<Profile> GetAll();
    }
}