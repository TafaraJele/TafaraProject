using EmployeesRecord.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeesRecordCommand.Core
{
    public class HrApiResult
    {
        public List<string> Messages { get; set; }

        public bool IsValid { get; set; }


    }
}
