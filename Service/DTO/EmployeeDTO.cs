namespace Employees_Application.Service.DTO{
    public class EmployeeDTO{
            public Guid? Id { get; set; }
            public string FullName { get; set; }
            public string Email { get; set; }
            public string PhoneNumber { get; set; }
            public string Address { get; set; }
            public string CompanyCategory { get; set; }
            public bool Gender { get; set; }
        }
    
}