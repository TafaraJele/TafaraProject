using EmployeesRecord.Core.Models;
using EmployeesRecordCommand.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesRecordCommand.Core.Service
{
    public interface IEmployeeService
    {
        

        ApiResult Create(Employee employee);
        HrApiResult CreateInfo(HRInformation hRInformation);
        string UpdateEmployee(Guid Id, Employee employee);
        string DeleteEmployee(Guid Id);
        string EditEmployeeInfo(Guid Id, HRInformation hRInformation);
        void DeleteInformation(Guid id);
       
    }
}
