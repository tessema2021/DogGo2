using DogGO.Models;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace DogGO.Repositories
{
    public interface IWalkerRepository
    {
        List<Walker> GetAllWalkers();
        List<Walker> GetWalkersInNeighborhood(int neighborhoodId);
        Walker GetWalkerById(int id);
        void UpdateWalker(Walker walker);
        void AddWalker(Walker walker);
    }
}