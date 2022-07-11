using System.ComponentModel.DataAnnotations;
namespace FinalTest.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        [Required(ErrorMessage = "Please Enter First Name")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Location { get; set; }
    }
}
