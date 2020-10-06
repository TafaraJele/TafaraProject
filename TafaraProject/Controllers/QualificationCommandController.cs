
using EmployeesRecord.Core.Models;
using EmployeesRecord.Core.Service;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeesCommand.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QualificationCommandController : ControllerBase
    {
        // GET: api/<QualificationCommandController>
        private readonly EmployeeCommandService qualificationService;

        public QualificationCommandController(EmployeeCommandService _qualificationService)

        {
            qualificationService = _qualificationService;

        }


        [HttpGet]
        // public ActionResult<List<EmployeeQualification>> GetEmployeeQualifications() =>

        //qualificationService.GetEmployeeQualifications();
        public ActionResult<List<EmployeeQualification>> GetEmployeeQualifications()
        {
            var result = qualificationService.GetEmployeeQualifications();

            return Ok(result);
        }


        // GET api/<QualificationCommandController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<QualificationCommandController>
        //[HttpPost]
        //public string Create(EmployeeQualification employeeQualification)
        //{
        //     qualificationService.Create(employeeQualification);

        //    return "successful";

        // PUT api/<QualificationCommandController>/5
        //    [HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        // DELETE api/<QualificationCommandController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
   // }
}
}
