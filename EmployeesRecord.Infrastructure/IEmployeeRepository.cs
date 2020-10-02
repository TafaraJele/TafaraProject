using EmployeesRecord.Core.Entities;
using EmployeesRecord.Infrastructure.Entities;
using System;
using System.Collections.Generic;

namespace EmployeesRecord.Infrastructure
{
    public interface IEmployeeRepository
    {

        string EmployeeCollectionName { get; set; }

        //string QualificationCollectionName { get; set; }

        string ConnectionString { get; set; }

        string DatabaseName { get; set; }

        List<EmployeeEntity> GetEmployees();
       // EmployeeEntity Create(EmployeeEntity employee);

        //EmployeeEntity GetEmployee(Guid Id);

        // List<HRInformationEntity> HRInformation { get; }
    }


}

