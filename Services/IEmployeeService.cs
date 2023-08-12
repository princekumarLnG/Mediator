using Mediator.Models;

namespace Mediator.Services
{
    public interface IEmployeeService
    {
        
        
        Task<List<Employee>> GetEmployeeListAsync();
        Task<Employee> GetEmployeeByIdAsync(int id);
        Task<Employee> AddEmployeeAsync(Employee employee);
        Task<int> UpdateEmployeeAsync(Employee employee);
        Task<int> DeleteEmployeeAsync(int id);

    }
}
