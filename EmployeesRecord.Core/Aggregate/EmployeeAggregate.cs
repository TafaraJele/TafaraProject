using EmployeesRecord.Core.Entities;
using EmployeesRecord.Core.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Text;

namespace EmployeesRecordCommand.Core.Aggregate
{
   public class EmployeeAggregate 
    {
        public EmployeeEntity Entity { get; set; }
       ApiResult apiResult = new ApiResult();
        public EmployeeAggregate()
        {
            Entity = new EmployeeEntity();
        }
        //private ApiResult ValidateEmployee(Employee employee)
        private ApiResult ValidateEmployee(Employee employee)
        {
           // var _messages = new List<string>();
            if (employee.Id == Guid.Empty)
            {
                apiResult.Messages.Add("EmployeeId is requred");
                apiResult.IsValid = false;
            }
            else if (employee.JobTitle == null)
            {
                apiResult.Messages.Add("JobTitle is requred");
                apiResult.IsValid = false;
            }
            else if (employee.Surname == null)
                
            {
                apiResult.Messages.Add("Employee Surname is required");
                apiResult.IsValid = false;
            }
                       
       
                return apiResult;
            
        }


       public ApiResult SaveEmployee(Employee employee)
           // public bool SaveEmployee(Employee employee)
        {
            var apiResult = ValidateEmployee(employee);
            if (apiResult.IsValid)

            
            {
                apiResult.Id = employee.Id;
                Entity.Id = employee.Id;
                Entity.JobTitle = employee.JobTitle;
                Entity.Name = employee.Name;
                Entity.Surname = employee.Surname;
                Entity.Department = employee.Department;
            
               
            }
            
            return apiResult;
        }
    }
}
