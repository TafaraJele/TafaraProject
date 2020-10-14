using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeesQuery.QueryService;
using EmployeesRecordCommand.Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeesQuery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QualificationCommandController : ControllerBase
    {
        private readonly EmployeeQueryService _employeeQueryService;


        public QualificationCommandController(EmployeeQueryService employeeQueryService)
        {

            _employeeQueryService = employeeQueryService;
        }
        [HttpGet]
        public async Task<List<EmployeeQualification>> GetEmployeeQualifications() 
        {
            return await _employeeQueryService.GetEmployeeQualifications();
        }
    
    }
}
