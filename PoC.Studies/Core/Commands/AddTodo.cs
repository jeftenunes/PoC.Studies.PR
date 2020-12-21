using MediatR;

namespace PoC.Studies.Core.Commands
{
    public class AddTodo : IRequest
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}