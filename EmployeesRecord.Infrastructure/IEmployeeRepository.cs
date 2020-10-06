using EmployeesRecord.Core.Entities;
using EmployeesRecord.Infrastructure.Entities;
using System;
using System.Collections.Generic;

namespace EmployeesRecord.Infrastructure
{
    public interface IEmployeeRepository
    {

        
        List<EmployeeEntity> GetEmployees();

        //EmployeeEntity GetEmployee(Guid Id);

        string Create(EmployeeEntity employee);

        string UpdateEmployee(Guid Id,EmployeeEntity employee);

        string DeleteEmployee(Guid Id);
        
    }


}

