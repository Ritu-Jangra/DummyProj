namespace EmployeeService
{
    public class EmployeeService : IEmployeeService
    {
        private readonly List<Employee> _employees;

        public EmployeeService()
        {
            _employees = new List<Employee>
            {
                new Employee
                {
                    EmployeeId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    FirstName = "John",
                    LastName = "Doe",
                    UserName = "johndoe",
                    Email = "johndoe@example.com",
                    Department = DepartmentType.IT,
                    Salary = 60000.00m
                },
                new Employee
                {
                    EmployeeId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    FirstName = "Jane",
                    LastName = "Smith",
                    UserName = "janesmith",
                    Email = "janesmith@example.com",
                    Department = DepartmentType.HR,
                    Salary = 55000.00m
                },
                new Employee
                {
                    EmployeeId = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                    FirstName = "Alice",
                    LastName = "Johnson",
                    UserName = "alicejohnson",
                    Email = "alicejohnson@example.com",
                    Department = DepartmentType.Finance,
                    Salary = 50000.00m
                },
                new Employee
                {
                    EmployeeId = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    FirstName = "Bob",
                    LastName = "Brown",
                    UserName = "bobbrown",
                    Email = "bobbrown@example.com",
                    Department = DepartmentType.Sales,
                    Salary = 52000.00m
                }
            };
        }

        public List<Employee> GetAllEmployees()
        {
            return _employees;
        }

        public Employee? GetEmployeeById(Guid id)
        {
            return _employees.FirstOrDefault(e => e.EmployeeId == id);
        }
    }
}