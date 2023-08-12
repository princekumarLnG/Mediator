using Mediator.Data.Queries;
using Mediator.Services;
using Mediator.Models;
using MediatR;

namespace Mediator.Data.Handlers
{
    public class GetEmployeeHandler : IRequestHandler<GetEmployeeByIdQuery, Employee>
    {
        private readonly IEmployeeService _employeeService;
        public GetEmployeeHandler(IEmployeeService employeeService)
        {
            _employeeService = employeeService;            
        }
        public async Task<Employee> Handle(GetEmployeeByIdQuery request, CancellationToken cancellationToken)
        {
            return await _employeeService.GetEmployeeByIdAsync(request.Id);
        }
    }
}
