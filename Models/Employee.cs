namespace Employees_Application.Models
{
    public class Employee{
        public Guid Id { get; set;}
        public string FullName { get; set;}
        public string Email { get; set;}
        public long PhoneNumber { get; set;}

        public string StaffCode { get; set;}
    }
}