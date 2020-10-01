using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeesRecord.Infrastructure.Entities
{
    class QualificationEntity
    {

        public Guid Id { get; set; }
        public Guid EmployeeId { get; set; }
        public string Name { get; set; }

        public int Year { get; set; }

        public string Academy { get; set; }

    }
}
