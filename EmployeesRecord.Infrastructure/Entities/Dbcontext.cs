using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeesRecord.Infrastructure.Entities
{
    public class Dbcontext
    {
        public string EmployeeCollectionName { get; set; }

        public string QualificationCollectionName { get; set; }

        public string HRInformationCollectionName { get; set; }

        public string ConnectionString { get; set; }

        public string DatabaseName { get; set; }
    }
}
