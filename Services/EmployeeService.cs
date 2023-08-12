using Mediator.Data;
using Mediator.Models;
using Microsoft.EntityFrameworkCore;

namespace Mediator.Services
{
    public class EmployeeService: IEmployeeService
    {
        private readonly AppDbContext _dbContext;
        public EmployeeService(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;            
        }

        public async Task<List<Employee>> GetEmployeeListAsync()
        {
            return await _dbContext.Employees.ToListAsync();
        }

        public async Task<Employee> GetEmployeeByIdAsync(int id)
        {
            var emp  = await _dbContext.Employees.FirstOrDefaultAsync(emp => emp.Id == id);
            return emp;
        }
        public async Task<Employee> AddEmployeeAsync(Employee employee)
        {
            var result = await _dbContext.Employees.AddAsync(employee);
            _dbContext.SaveChanges();
            return result.Entity;

        }
        public async Task<int> UpdateEmployeeAsync(Employee employee)
        {
            _dbContext.Employees.Update(employee);
            return await _dbContext.SaveChangesAsync();

        }
        public async Task<int> DeleteEmployeeAsync(int id)
        {
            var data = await _dbContext.Employees.FirstOrDefaultAsync(_ => _.Id == id);
            if (data != null) { _dbContext.Employees.Remove(data); }
            return await _dbContext.SaveChangesAsync();
        }
    }
}
