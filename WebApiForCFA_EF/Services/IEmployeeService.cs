using WebApiForCFA_EF.Models;
using WebApiForCFA_EF.ViewModels;


namespace WebApiForCFA_EF.Services
{
    public interface IEmployeeService
    {
        List<Employee> GetEmployeesList();


        Employee GetEmployeeDetailsById(int empId);

     
        ResponseModel SaveEmployee(Employee employeeModel);


  
        ResponseModel DeleteEmployee(int employeeId);

    }

}
