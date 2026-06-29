namespace EmployeeService
{
    public class Employee
    {
        public Guid EmployeeId { get; set; }

        public required string FirstName { get; set; }

        public string? LastName { get; set; }

        public required string UserName { get; set; }

        public required string Email { get; set; }

        //public string? Password { get; set; }

        //public required string PasswordHash { get; set; }

        public required DepartmentType Department { get; set; }

        public required decimal Salary { get; set; }

        #region Manager-Employee relationship (self-referencing)

        public Guid? ManagerId { get; set; }    // Nullable for top-level admins

        // Navigation to manager
        public Employee? Manager { get; set; }

        #endregion Manager-Employee relationship (self-referencing)
    }

    public enum DepartmentType
    {
        HR,
        IT,
        Finance,
        Sales
    }
}
