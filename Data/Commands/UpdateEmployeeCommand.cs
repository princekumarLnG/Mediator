using Mediator.Models;
using MediatR;

namespace Mediator.Data.Commands
{
    public class UpdateEmployeeCommand : IRequest<int>
    {
        public UpdateEmployeeCommand(int id,string name, string email, string phone, Gender gender)
        {
            Id = id;
            Name = name;
            Email = email;
            Phone = phone;
            Gender = gender;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Gender Gender { get; set; }
    }
}
