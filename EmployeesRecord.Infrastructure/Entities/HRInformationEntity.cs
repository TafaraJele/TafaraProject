using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeesRecord.Infrastructure.Entities
{
   public class HRInformationEntity
    {
        public Guid EmployeeId { get; set; }

        public int ECnumber { get; set; }

        public int Salary { get; set; }

        public int MedicalAidType { get; set; }

        public string EmployeeCategory { get; set; }
    }
}
