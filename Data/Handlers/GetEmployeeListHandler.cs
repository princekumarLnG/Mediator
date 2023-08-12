using Mediator.Data.Queries;
using Mediator.Services;
using Mediator.Models;
using MediatR;

namespace Mediator.Data.Handlers
{
    public class GetEmployeeListHandler : IRequestHandler<GetEmployeeListQuery, List<Employee>>
    {

        private readonly IEmployeeService _employeeService;
        public GetEmployeeListHandler( IEmployeeService employeeService)
        {
            _employeeService = employeeService;            
        }
        public async Task<List<Employee>> Handle(GetEmployeeListQuery request, CancellationToken cancellationToken)
        {
            return await _employeeService.GetEmployeeListAsync();   
        }
    }
}
