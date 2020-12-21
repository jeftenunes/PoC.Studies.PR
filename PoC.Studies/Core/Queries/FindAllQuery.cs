using MediatR;
using PoC.Studies.Core.Domain;
using System.Collections.Generic;

namespace PoC.Studies.Core.Queries
{
    public class FindAllQuery : IRequest<IEnumerable<Todo>>
    {

    }
}