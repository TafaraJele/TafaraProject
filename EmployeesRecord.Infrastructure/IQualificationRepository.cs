using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeesRecord.Infrastructure.Entities
{
    interface IQualificationRepository
    {
        List<QualificationEntity> GetQualifications();




    }
}
