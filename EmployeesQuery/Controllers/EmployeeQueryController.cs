using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeQuery.QueryService;
using EmployeesRecord.Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeesQuery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeQueryController : ControllerBase
    {
        private readonly EmployeeQueryService employeeService;

        public EmployeeQueryController(EmployeeQueryService _employeeService)

        {
            employeeService = _employeeService;

        }
        //GET: api/Employee

        [HttpGet]
        public async Task<ActionResult<List<Employee>>> GetEmployees()
        {
            var result = await employeeService.GetEmployees();

            return Ok(result);
        }

        // GET: api/Employee/5
        //[HttpGet]
        //[Route("{Id}")]
        //public Employee GetEmployee(Guid Id)
        //{

        //    return employeeService.GetEmployee(Id);           

        //}

        
    }
}
