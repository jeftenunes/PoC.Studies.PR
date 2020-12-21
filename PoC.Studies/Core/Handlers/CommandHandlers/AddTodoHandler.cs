using MediatR;
using System.Threading;
using System.Threading.Tasks;
using PoC.Studies.Core.Domain;
using PoC.Studies.Core.Commands;
using PoC.Studies.Core.Repository.Interfaces;
using PoC.Studies.Core.Handlers.CommandHandlers.Interfaces;

namespace PoC.Studies.Core.Handlers.CommandHandlers
{
    public class AddTodoHandler : IAddTodoHandler, IRequestHandler<AddTodo>
    {
        private readonly ITodoRepository repository;

        public AddTodoHandler(ITodoRepository repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(AddTodo request, CancellationToken cancellationToken)
        {
            await repository.AddAsync(new Todo(repository.NextId(), request.Title, request.Description));
            return await Task.FromResult(Unit.Value);
        }
    }
}