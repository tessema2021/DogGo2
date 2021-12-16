using DogGO.Models;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace DogGO.Repositories
{
    public interface IWalkerRepository
    {
        List<Walker> GetAllWalkers();
        List< Walk> GetWalksByWalkerId(int id);
        List<Walker> GetWalkersInNeighborhood(int neighborhoodId);
        Walker GetWalkerById(int id);
    }
}