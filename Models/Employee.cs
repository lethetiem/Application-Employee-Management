namespace Employees_Application.Models
{
    public enum Gender
    {
        Male,
        Female
    }

    public class Employee{
        public Guid Id { get; set;}
        public string FullName { get; set;}
        public string Email { get; set;}
        public long PhoneNumber { get; set;}
        public string Address {get; set;}
        public string CompanyCategory {get; set;}
        public Gender Gender { get; set;}
    }
}