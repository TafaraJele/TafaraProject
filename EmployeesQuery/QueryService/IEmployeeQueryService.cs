using EmployeesRecord.Core.Models;
using EmployeesRecordCommand.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesQuery.QueryService
{
    interface IEmployeeQueryService
    {
        Task<List<Employee>> GetEmployees();
        List<EmployeeQualification> GetEmployeeQualifications();
        Task<List<HRInformation>>GetHRInformation();
    }
}
