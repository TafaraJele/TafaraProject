using EmployeesRecord.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesRecord.Core.Service
{
    public interface IEmployeeService
    {
        List<Employee> GetEmployees();

        //Employee Get(Guid Id);

        //Employee Create(Employee employee);

        List<EmployeeQualification> GetEmployeeQualifications();

        List<HRInformation> GetHRInformation();
    }
}
