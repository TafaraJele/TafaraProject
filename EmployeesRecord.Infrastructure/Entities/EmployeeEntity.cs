using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeesRecord.Core.Entities
{
    public class EmployeeEntity
    {
        public string Department { get; set; }
        public string JobTitle { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public Guid Id { get; set; }
    }
}
