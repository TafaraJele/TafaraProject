using EmployeesRecord.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeesRecord.Infrastructure
{
    public interface IQualificationRepository
    {
       

        List<QualificationEntity> GetEmployeeQualifications();




    }
}
