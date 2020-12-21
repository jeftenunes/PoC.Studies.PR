using MediatR;
using System.Threading;
using System.Threading.Tasks;
using PoC.Studies.Core.Domain;
using PoC.Studies.Core.Queries;
using System.Collections.Generic;
using PoC.Studies.Core.Repository.Interfaces;
using PoC.Studies.Core.Handlers.QueryHandlers.Interfaces;

namespace PoC.Studies.Core.Handlers.QueryHandlers
{
    public class FindAllQueryHandler : IFindAllQueryHandler, IRequestHandler<FindAllQuery, IEnumerable<Todo>>
    {
        private readonly ITodoRepository todoRepository;

        public FindAllQueryHandler(ITodoRepository todoRepository)
        {
            this.todoRepository = todoRepository;
        }

        public async Task<IEnumerable<Todo>> Handle(FindAllQuery request, CancellationToken cancellationToken)
        {
            return await todoRepository.FindAllAsync();
        }
    }
}