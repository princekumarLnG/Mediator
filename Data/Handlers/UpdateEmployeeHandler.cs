using Mediator.Data.Commands;
using Mediator.Services;
using MediatR;

namespace Mediator.Data.Handlers
{
    public class UpdateEmployeeHandler : IRequestHandler<UpdateEmployeeCommand, int>
    {
        private readonly IEmployeeService _employeeService;
        public UpdateEmployeeHandler( IEmployeeService employeeService)
        {
            _employeeService = employeeService;            
        }
        public async Task<int> Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = await _employeeService.GetEmployeeByIdAsync(request.Id);
            if (employee == null) return default;
            
            employee.Name = request.Name;
            employee.Email = request.Email;
            employee.Phone = request.Phone;
            employee.Gender = request.Gender;

            return await _employeeService.UpdateEmployeeAsync(employee);
        }
    }
}
