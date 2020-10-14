
using EmployeesRecordCommand.Core.Models;
using EmployeesRecordCommand.Core.Service;
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



        // POST api/<QualificationCommandController>
        //[HttpPost]
        //public string Create(EmployeeQualification employeeQualification)
        //{
        //    qualificationService.Create(employeeQualification);

        //    return "successful";
        //}
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
