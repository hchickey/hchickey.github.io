using MyProfile.Models;
using System.Collections.Generic;

namespace MyProfile.Repositories
{
    public interface IInterestRepository
    {
        List<Interest> GetAll();
    }
}