using System.Linq;
using System.Threading.Tasks;
using PoC.Studies.Core.Domain;
using System.Collections.Generic;
using PoC.Studies.Core.Repository.Interfaces;

namespace PoC.Studies.Core.Repository
{
    public class TodoRepository : ITodoRepository
    {
        private static readonly List<Todo> todos = new List<Todo>();

        public int NextId() => todos.Count() + 1;
        public async Task AddAsync(Todo todo) => await Task.Run(() => todos.Add(todo));
        public async Task<IEnumerable<Todo>> FindAllAsync() => await Task.FromResult(todos.ToList());
        public async Task<Todo> FindByIdAsync(int id) => await Task.FromResult(todos.FirstOrDefault(t => id.Equals(t.Id)));
    }
}