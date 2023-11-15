using WebApiForCFA_EF.Models;
using WebApiForCFA_EF.ViewModels;

namespace WebApiForCFA_EF.Services
{
    public class EmployeeService : IEmployeeService
    {
        private EmpContext _context;
        public EmployeeService(EmpContext context)
        {
            _context = context;
        }

        public List<Employee> GetEmployeesList()
        {
            List<Employee> empList;
            try
            {
                empList = _context.Set<Employee>().ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return empList;
        }

        public Employee GetEmployeeDetailsById(int empId)
        {
            Employee emp;
            try
            {
                emp = _context.Find<Employee>(empId);
            }
            catch (Exception)
            {
                throw;
            }
            return emp;
        }

       
        public ResponseModel SaveEmployee(Employee employeeModel)
        {
            ResponseModel model = new ResponseModel();
            try
            {
                Employee _temp = GetEmployeeDetailsById(employeeModel.EmployeeId);
                if (_temp != null)
                {
                    _temp.Designation = employeeModel.Designation;
                    _temp.EmployeeFirstName = employeeModel.EmployeeFirstName;
                    _temp.EmployeeLastName = employeeModel.EmployeeLastName;
                    _temp.Salary = employeeModel.Salary;
                    _temp.DepartmentId= employeeModel.DepartmentId;
                    _context.Update<Employee>(_temp);
                    model.Messsage = "Employee Update Successfully";
                }
                else
                {
                    _context.Add<Employee>(employeeModel);
                    model.Messsage = "Employee Inserted Successfully";
                }
                _context.SaveChanges();
                model.IsSuccess = true;
            }
            catch (Exception ex)
            {
                model.IsSuccess = false;
                model.Messsage = "Error : " + ex.Message;
            }
            return model;
        }

       
        public ResponseModel DeleteEmployee(int employeeId)
        {
            ResponseModel model = new ResponseModel();
            try
            {
                Employee _temp = GetEmployeeDetailsById(employeeId);
                if (_temp != null)
                {
                    _context.Remove<Employee>(_temp);
                    _context.SaveChanges();
                    model.IsSuccess = true;
                    model.Messsage = "Employee Deleted Successfully";
                }
                else
                {
                    model.IsSuccess = false;
                    model.Messsage = "Employee Not Found";
                }
            }
            catch (Exception ex)
            {
                model.IsSuccess = false;
                model.Messsage = "Error : " + ex.Message;
            }
            return model;
        }
    }

}
