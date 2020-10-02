using EmployeesRecord.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeesRecord.Infrastructure
{
    public interface IQualificationRepository
    {
        string EmployeeCollectionName { get; set; }

        string QualificationCollectionName { get; set; }

        string ConnectionString { get; set; }

        string DatabaseName { get; set; }

        List<QualificationEntity> GetEmployeeQualifications();




    }
}
