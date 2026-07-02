using EmployeeService;
using Moq;

namespace Employee_Leave_Management_UnitTests
{
    [TestClass]
    public sealed class EmployeeServiceTests
    {

        private IEmployeeService GetMoqEmployeeService(Guid id)
        {
            var result = new Mock<IEmployeeService>();

            GetEmployeeById(result, id);

            return result.Object;
        }

        private static void GetEmployeeById(Mock<IEmployeeService> service, Guid id)
        {
            Employee? employee;

            switch (id.ToString())
            {
                case "00000000-0000-0000-0000-000000000001":
                    employee = new Employee
                    {
                        EmployeeId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                        FirstName = "John",
                        LastName = "Doe",
                        UserName = "johndoe",
                        Email = "johndoe@example.com",
                        Department = DepartmentType.IT,
                        Salary = 60000.00m
                    };
                    break;
                default:
                    employee = null;
                    break;
            }

            service.Setup(x => x.GetEmployeeById(It.IsAny<Guid>())).Returns(employee);
        }

        [TestMethod]
        public void GetEmployeeById_ShouldReturnEmployee()
        {
            //Arrange
            Guid employeeId = Guid.Parse("00000000-0000-0000-0000-000000000001");
            IEmployeeService _employeeService = GetMoqEmployeeService(employeeId);

            //Act
            Employee? employee = _employeeService.GetEmployeeById(employeeId);

            //Assert
            Assert.IsNotNull(employee);
        }

        [TestMethod]
        public void GetEmployeeById_ShouldReturnNull()
        {
            //Arrange
            Guid employeeId = Guid.Parse("00000000-0000-0000-0000-000000000005");
            IEmployeeService _employeeService = GetMoqEmployeeService(employeeId);

            //Act
            Employee? employee = _employeeService.GetEmployeeById(employeeId);

            //Assert
            Assert.IsNull(employee);
        }
    }
}
