using MediatR;
using PoC.Studies.Core.Domain;
using System.Collections.Generic;

namespace PoC.Studies.Core.Queries
{
    public class FindByIdQuery : IRequest<Todo>
    {
        public int Id { get; set; }
    }
}
