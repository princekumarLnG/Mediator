using Mediator.Data.Commands;
using Mediator.Services;
using Mediator.Models;
using MediatR;

namespace Mediator.Data.Handlers
{
    public class CreateEmployeeHandler : IRequestHandler<CreateEmployeeCommand, Employee>
    {
        private readonly IEmployeeService _employeeService;
        public CreateEmployeeHandler(IEmployeeService employeeService)
        {
            _employeeService = employeeService;            
        }
        public async Task<Employee> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            Employee newEmployee = new Employee
            {
                Name = request.Name,
                Email = request.Email,
                Phone = request.Phone,
                Gender = request.Gender,
            };

            return await _employeeService.AddEmployeeAsync(newEmployee);
        }
    }
}
