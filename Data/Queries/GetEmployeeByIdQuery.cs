using Mediator.Models;
using MediatR;

namespace Mediator.Data.Queries
{
    public class GetEmployeeByIdQuery :IRequest<Employee>
    {
        public int Id { get; set; }
    }
}
