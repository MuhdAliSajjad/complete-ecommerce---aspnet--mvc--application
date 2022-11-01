using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Models;

namespace Ecommerce.Data.Services
{
    public interface IActorService
    {
        Task<IEnumerable<ActorModel>> GetAllAsync();

        Task<ActorModel> GetByIdAsync(int id);

        Task AddAsync(ActorModel actor);

        Task<ActorModel> UpdateAsync(int id, ActorModel newActor);

        Task DeleteAsync(int id);
    }
}
