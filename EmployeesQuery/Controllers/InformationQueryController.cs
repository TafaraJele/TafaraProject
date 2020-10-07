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
    public class InformationQueryController : ControllerBase
    {
        private readonly EmployeeQueryService _employeeQueryService;

        public InformationQueryController(EmployeeQueryService employeeQueryService)
        {
            _employeeQueryService = employeeQueryService;

        }

        public async Task<List<HRInformation>> GetHRInformation()
        {
            return await _employeeQueryService.GetHRInformation();
        }    


    }
}
