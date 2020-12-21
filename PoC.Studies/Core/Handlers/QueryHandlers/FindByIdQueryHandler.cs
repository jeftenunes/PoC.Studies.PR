using MediatR;
using System.Threading;
using System.Threading.Tasks;
using PoC.Studies.Core.Domain;
using PoC.Studies.Core.Queries;
using PoC.Studies.Core.Repository.Interfaces;
using PoC.Studies.Core.Handlers.QueryHandlers.Interfaces;

namespace PoC.Studies.Core.Handlers.QueryHandlers
{
    public class FindByIdQueryHandler : IFindByIdQueryHandler, IRequestHandler<FindByIdQuery, Todo>
    {
        private readonly ITodoRepository todoRepository;

        public FindByIdQueryHandler(ITodoRepository todoRepository)
        {
            this.todoRepository = todoRepository;
        }

        public async Task<Todo> Handle(FindByIdQuery request, CancellationToken cancellationToken)
        {
            return await todoRepository.FindByIdAsync(request.Id);
        }
    }
}
