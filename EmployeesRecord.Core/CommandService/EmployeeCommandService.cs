using EmployeesRecord.Core.Entities;
using EmployeesRecord.Core.Models;
using EmployeesRecord.Infrastructure;
using EmployeesRecord.Infrastructure.Entities;
using EmployeesRecordCommand.Core.Aggregate;
using EmployeesRecordCommand.Core.Models;
using System;
using System.Collections.Generic;


namespace EmployeesRecordCommand.Core.Service
{
    public class EmployeeCommandService : IEmployeeService
    {

        private readonly IEmployeeRepository _employeeRepository;
        private readonly IQualificationRepository _qualificationRepository;
        private readonly IHRInformationRepository _hrInformationRepository;


        public EmployeeCommandService(IEmployeeRepository employeeRepository, IQualificationRepository qualificationRepository, IHRInformationRepository hrInformationRepository)
        {

            _employeeRepository = employeeRepository;
            _qualificationRepository = qualificationRepository;
            _hrInformationRepository = hrInformationRepository;

        }
       
        public  ApiResult Create(Employee employee)
        {
            var aggregate = new EmployeeAggregate();

                       
            employee.Id = Guid.NewGuid();

            

            var apiResult =  aggregate.SaveEmployee(employee);
           //ApiResult apiResult = new ApiResult();

            if (apiResult.IsValid)
            {
                _employeeRepository.Create(aggregate.Entity);
            }
            return apiResult;                               

           
        }
        public HrApiResult CreateInfo(HRInformation hRInformation)
        {
            var aggregate = new HRInformationAggregate();

            var hrApiResult = aggregate.SaveHrInformation(hRInformation);

            
            if (hrApiResult.IsValid)
            {
                _hrInformationRepository.CreateInfo(aggregate.HrEntity);
            }
            return hrApiResult;
        }

        public string UpdateEmployee(Guid Id, Employee employee)
        {
            var employee1 = new EmployeeEntity
            {
                Id = employee.Id,
                Department = employee.Department,
                JobTitle = employee.JobTitle,
                Name = employee.Name,
                Surname = employee.Surname

            };
            employee.Id = Guid.NewGuid();
            _employeeRepository.UpdateEmployee(Id, employee1);

            return employee.Id.ToString();
        }

        public string DeleteEmployee(Guid Id)
        {

            _employeeRepository.DeleteEmployee(Id);

            return "Successfully deleted";
        }

        public string EditEmployeeInfo(Guid Id, HRInformation hRInformation)
        {
            var hRinfors = new HRInformationEntity
            { 
                EmployeeId = hRInformation.EmployeeId,
                ECnumber = hRInformation.ECnumber,
                EmployeeCategory =hRInformation.EmployeeCategory,
                MedicalAidType =hRInformation.MedicalAidType,
                Salary = hRInformation.Salary
            };


            _hrInformationRepository.EditEmployeeInfo(Id, hRinfors);

            return "Employee Information Successfully Updated";

        }
        public void DeleteInformation(Guid id)
        {
            _hrInformationRepository.DeleteInformation(id);

        }
    }

}












