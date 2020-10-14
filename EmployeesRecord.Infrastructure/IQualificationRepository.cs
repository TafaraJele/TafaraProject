using EmployeesRecord.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesRecord.Infrastructure
{
    public interface IQualificationRepository
    {
       

        Task<List<QualificationEntity>> GetEmployeeQualifications();




    }
}
