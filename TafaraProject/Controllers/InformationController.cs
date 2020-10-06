using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeesRecord.Core.Models;
using EmployeesRecord.Core.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeesWrite.Controllers
{
    [Route("api/[controller]")]
    public class InformationController : Controller
    {
        private readonly EmployeeService employeeService;

        public InformationController(EmployeeService _employeeService)

        {
            employeeService = _employeeService;

        }



        // GET: api/<controller>
        [HttpGet]
        public List<HRInformation> GetHRInformation()
        {

            var result = employeeService.GetHRInformation();

            return result;
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public string CreateInfo( [FromBody]  HRInformation hRInformation)
        {
            employeeService.CreateInfo(hRInformation);

            return "Employee information successfully uploaded";
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
