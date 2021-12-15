using DogGO.Models;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace DogGO.Repositories
{
    public interface IWalkerRepository
    {
        List<Walker> GetAllWalkers();
        Walker GetWalkerById(int id);
        List<Walker> GetWalkersInNeighborhood(int neighborhoodId);
    }
}