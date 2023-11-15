using WebApiForCFA_EF.Models;
using WebApiForCFA_EF.ViewModels;

namespace WebApiForCFA_EF.Services
{
    public interface IDepartmentService
    {
        List<Department> GetDepartmentList();

        Department GetDepartmentDetailsById(int deptId);

        ResponseModel SaveDepartment(Department departmentModel);

        ResponseModel DeleteDepartment(int departmentId);
    }
}
