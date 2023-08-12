using Mediator.Models;
using MediatR;

namespace Mediator.Data.Commands
{
    public class CreateEmployeeCommand : IRequest<Employee>
    {
        public CreateEmployeeCommand(string name,string email,string phone,Gender gender)
        {
            Name = name;
            Email = email;
            Phone = phone;
            Gender = gender;            
        }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Gender Gender { get; set; }
    }
}
