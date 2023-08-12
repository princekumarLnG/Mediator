using MediatR;

namespace Mediator.Data.Commands
{
    public class DeleteEmployeeCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}
