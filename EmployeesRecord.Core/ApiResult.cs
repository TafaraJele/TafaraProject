using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeesRecordCommand.Core
{
    public class ApiResult
    {
        public ApiResult()
        {
            IsValid = true;
        }

        public Guid Id { get; set; }
        public bool IsValid { get; set; }
        public List<string> Messages { get; set; }
    }
}
