using System.ComponentModel.DataAnnotations;

namespace WebApiForCFA_EF.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId{get; set;}
        public string EmployeeFirstName { get; set; }

        public string EmployeeLastName { get; set; }

        public decimal Salary { get; set; }

        public string Designation { get; set; }

        public int DepartmentId { get; set; }

        //public Department Department { get; set; }

    }
}
