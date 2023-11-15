using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiForCFA_EF.Models;
using WebApiForCFA_EF.Services;

namespace WebApiForCFA_EF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
       IDepartmentService _departmentService;

        public DepartmentController(IDepartmentService service)
        {
            _departmentService= service;
        }

        [HttpGet]
        [Route("[action]")]
        public IActionResult GetAllDepartment()
        {
            try
            {
                var department = _departmentService.GetDepartmentList(); 
                if (department == null) 
                    return NotFound();
                return Ok(department);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }


        [HttpPost]
        [Route("[action]")]
        public IActionResult SaveDepartment(Department departmentModel)
        {
            try
            {
                var model = _departmentService.SaveDepartment(departmentModel);
                return Ok(model);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        [Route("[action]")]
        public IActionResult DeleteDepartment(int id)
        {
            try
            {
                var model =_departmentService.DeleteDepartment(id);
                return Ok(model);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
