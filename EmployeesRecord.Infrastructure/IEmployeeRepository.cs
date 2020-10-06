using EmployeesRecord.Core.Entities;
using EmployeesRecord.Infrastructure.Entities;
using System;
using System.Collections.Generic;

namespace EmployeesRecord.Infrastructure
{
    public interface IEmployeeRepository
    {

        
        List<EmployeeEntity> GetEmployees();
        string Create(EmployeeEntity employee);

        
    }


}

