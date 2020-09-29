
using EmployeesRecord.Core.Models;
using EmployeesRecord.Core.Service;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeesWrite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QualificationController : ControllerBase
    {
        // GET: api/<QualificationController>
        private readonly EmployeeService qualificationService;

        public QualificationController(EmployeeService _qualificationService)

        {
            qualificationService = _qualificationService;

        }


        [HttpGet]
        public ActionResult<List<EmployeeQualification>> GetEmployeeQualifications() =>

            qualificationService.GetEmployeeQualifications();


        // GET api/<QualificationController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<QualificationController>
        [HttpPost]
        public string Create(EmployeeQualification employeeQualification)
        {
             qualificationService.Create(employeeQualification);

            return "successful";

            // PUT api/<QualificationController>/5
            //    [HttpPut("{id}")]
            //public void Put(int id, [FromBody] string value)
            //{
            //}

            // DELETE api/<QualificationController>/5
            //[HttpDelete("{id}")]
            //public void Delete(int id)
            //{
        }
    }
}
