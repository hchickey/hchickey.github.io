using MyProfile.Models;
using System.Collections.Generic;

namespace MyProfile.Repositories
{
    public interface IBasicRepository
    {
        List<Basic> GetAll();
    }
}