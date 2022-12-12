using MyProfile.Models;
using System.Collections.Generic;

namespace MyProfile.Repositories
{
    public interface IWorkRepository
    {
        List<Work> GetAll();
    }
}