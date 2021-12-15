using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DogGO.Models;

namespace DogGO.Repositories
{
   
        public interface IOwnerRepository
        {
        void AddOwner(Owner owner);
        void DeleteOwner(int ownerId);
        List<Owner> GetAllOwners();
        Owner GetOwenrById(int id);
        Owner GetOwnerByEmail(string email);
        Owner GetOwnerById(int id);
        void UpdateOwner(Owner owner);
    }
    
}
