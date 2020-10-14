using EmployeesRecord.Infrastructure.Entities;
using EmployeesRecordCommand.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeesRecordCommand.Core.Aggregate
{
    public class HRInformationAggregate
    {

        public HRInformationEntity HrEntity { get; set; }

        HrApiResult hrApiResult = new HrApiResult();

        public HRInformationAggregate()
        {
            HrEntity = new HRInformationEntity();
        }

        private HrApiResult ValidateHrInformation(HRInformation hRInformation)
        {
            if (hRInformation.EmployeeId == Guid.Empty) 
            {
                hrApiResult.Messages.Add("Employee ID is required");
                hrApiResult.IsValid = false;
            
            };

            if (hRInformation.EmployeeCategory == null)
            {

                hrApiResult.Messages.Add("Employee EC number is required");
                hrApiResult.IsValid = false;
            }

            return hrApiResult;

        }

        public HrApiResult SaveHrInformation( HRInformation hRInformation)
        {
            var aggregate =  ValidateHrInformation(hRInformation);

            if(hrApiResult.IsValid)
            {
                HrEntity.ECnumber = hRInformation.ECnumber;
                HrEntity.EmployeeCategory = hRInformation.EmployeeCategory;
                HrEntity.EmployeeId = hRInformation.EmployeeId;
                HrEntity.MedicalAidType = hRInformation.MedicalAidType;
                HrEntity.Salary = hRInformation.Salary;

            }

            return hrApiResult;

        }
    }
}
