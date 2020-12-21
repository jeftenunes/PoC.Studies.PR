using System.Threading.Tasks;
using PoC.Studies.Core.Domain;
using System.Collections.Generic;

namespace PoC.Studies.Core.Repository.Interfaces
{
    public interface ITodoRepository
    {
        int NextId();
        Task AddAsync(Todo todo);
        Task<Todo> FindByIdAsync(int id);
        Task<IEnumerable<Todo>> FindAllAsync();
    }
}