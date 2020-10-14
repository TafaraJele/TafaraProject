using EmployeesRecord.Core.Entities;
using EmployeesRecord.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeesRecord.Infrastructure
{
    public interface IEmployeeRepository
    {


        Task<List<EmployeeEntity>> GetEmployees();

        //EmployeeEntity GetEmployee(Guid Id);

        Guid Create(EmployeeEntity employee);

        string UpdateEmployee(Guid Id, EmployeeEntity employee);

        string DeleteEmployee(Guid Id);

    }


}

