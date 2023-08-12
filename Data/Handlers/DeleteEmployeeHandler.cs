using Mediator.Data.Commands;
using Mediator.Services;
using MediatR;

namespace Mediator.Data.Handlers
{
    public class DeleteEmployeeHandler : IRequestHandler<DeleteEmployeeCommand, int>
    {
        private readonly IEmployeeService _employeeService;
        public DeleteEmployeeHandler(IEmployeeService employeeService)
        {
            _employeeService = employeeService;            
        }
        public async Task<int> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = await _employeeService.GetEmployeeByIdAsync(request.Id);
            if (employee == null) return default;

            return await _employeeService.DeleteEmployeeAsync(request.Id);
        }
    }
}
