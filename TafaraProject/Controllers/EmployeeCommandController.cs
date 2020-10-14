using EmployeesRecord.Core.Models;
using EmployeesRecordCommand.Core;
using EmployeesRecordCommand.Core.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TafaraProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeCommandController : ControllerBase
    {

        private readonly EmployeeCommandService employeeService;
        ApiResult apiResult = new ApiResult();
        public EmployeeCommandController(EmployeeCommandService _employeeService)

        {
            employeeService = _employeeService;

        }
       

        //POST: api/Employee
        [HttpPost]
        public ApiResult Create ([FromBody] Employee employee)
            
        {
              employeeService.Create(employee);

            return apiResult;
        }
    
        // PUT: api/Employee/5
        [HttpPut]
        [Route("{Id}")]
        public string UpdateEmployee(Guid Id, [FromBody] Employee employee)
        {

            employeeService.UpdateEmployee(Id, employee);

            return employee.Id.ToString();

        }
        [HttpDelete]
        [Route("{Id}")]

        public string DeleteEmployee(Guid Id)
        {

            employeeService.DeleteEmployee(Id);

            return "Employee suceessfully Deleted";
        }
    }
}




