using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeesRecord.Infrastructure.Entities
{
    class HRInformationEntity
    {
        public int ECnumber { get; set; }

        public int Salary { get; set; }

        public int MedicalAidType { get; set; }

        public string EmployeeCategory { get; set; }
    }
}
