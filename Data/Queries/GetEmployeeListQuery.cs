using Mediator.Models;
using MediatR;

namespace Mediator.Data.Queries
{
    public class GetEmployeeListQuery : IRequest<List<Employee>>
    {
    }
}
