using Mediator.Data.Commands;
using Mediator.Data.Queries;
using Mediator.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Mediator.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        private IMediator _mediator;
        public EmployeeController(IMediator mediator)
        {
            _mediator = mediator;            
        }

        [HttpGet]
        public async Task<List<Employee>> GetEmployeeList()
        {
            var empList = await _mediator.Send(new GetEmployeeListQuery());
            return empList;
        }

        [HttpGet("{id}")]
        public async Task<Employee> GetEmployeeById(int id)
        {
            var emp = await _mediator.Send(new GetEmployeeByIdQuery() { Id=id });
            return emp;
        }

        [HttpPost]
        public async Task<Employee> AddEmployee(Employee employee)
        {
            var newEmp = await _mediator.Send(new CreateEmployeeCommand(
                employee.Name,employee.Email,employee.Phone,employee.Gender));
            return newEmp;
        }

        [HttpPut]
        public async Task<int> UpdateEmployee(Employee employee)
        {
            var updateEmp = await _mediator.Send(new UpdateEmployeeCommand(
                employee.Id,employee.Name,employee.Email,employee.Phone,employee.Gender));

            return (int)updateEmp;
        }

        [HttpDelete("{id}")]
        public async Task<int> DeleteEmployee(int id)
        {
            return await _mediator.Send(new DeleteEmployeeCommand() { Id=id });
        }


    }
}
