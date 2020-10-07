using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeQuery.QueryService;
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

        public List<EmployeeQualification> GetEmployeeQualifications() 
        {
            return _employeeQueryService.GetEmployeeQualifications();
        }
    
    }
}
