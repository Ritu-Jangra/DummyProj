namespace EmployeeFeature
{
    public interface IEmployeeService
    {
        List<Employee> GetAllEmployees();

        Employee? GetEmployeeById(Guid id);
    }
}
