using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnimalNursery.Models.Animals;
namespace AnimalNursery.Services
{
    public interface IHomeFriendsRepository : IRepository<HomeFriend, int>
    {
        
    }
}