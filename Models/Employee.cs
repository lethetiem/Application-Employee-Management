using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Employees_Application.Models
{
    public class Employee{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set;}
        public string FullName { get; set;}
        public string Email { get; set;}
        public string PhoneNumber { get; set;}
        public string Address {get; set;}
        public string CompanyCategory {get; set;}
        public bool Gender { get; set;}
    }
}