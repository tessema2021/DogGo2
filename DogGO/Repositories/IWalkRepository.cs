using System;
using DogGO.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DogGO.Repositories
{
    public interface IWalkRepository
    {
        List<Walk> GetWalks();
        List<Walk> GetWalksByWalkerId(int WalkerId);
    }
}
