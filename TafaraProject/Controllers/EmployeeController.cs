﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeesRecord.Core.Models;
using EmployeesRecord.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TafaraProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        private readonly EmployeeService employeeService;

        public EmployeeController(EmployeeService _employeeService)

        {
            employeeService = _employeeService;

        }
        //GET: api/Employee

        [HttpGet]
        public ActionResult<List<Employee> >GetEmployees()
        {
          var  result = employeeService.GetEmployees();
            return Ok(result);
        }
            


       


        // GET: api/Employee/5
[HttpGet]
[Route("{Id}")]
        public Employee Get(Guid Id) =>
        
            employeeService.Get(Id);
                   
        

        // POST: api/Employee
        [HttpPost]
        public string Create( Employee employee)
        {
        var employee1= employeeService.Create(employee);

            return employee1.Id.ToString();
        }

        // PUT: api/Employee/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        
        
    }
}
