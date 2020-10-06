using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeesRecordCommand.Core.Models;
using EmployeesRecordCommand.Core.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeesCommand.Controllers
{
    [Route("api/[controller]")]
    public class InformationCommandController : Controller
    {
        private readonly EmployeeCommandService employeeService;

        public InformationCommandController(EmployeeCommandService _employeeService)

        {
            employeeService = _employeeService;

        }




        // POST api/<controller>
        [HttpPost]
        public string CreateInfo( [FromBody]  HRInformation hRInformation)
        {
            employeeService.CreateInfo(hRInformation);

            return "Employee information successfully uploaded";
        }

        //// PUT api/<controller>/5
        [HttpPut("{id}")]
        public string EditEmployeeInfo(Guid id, [FromBody] HRInformation hRInformation)
        {
            employeeService.EditEmployeeInfo(id, hRInformation);

            return "File successfully created";
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void DeleteInformation(Guid id)
        {
            employeeService.DeleteInformation(id);
        }
    }
}
