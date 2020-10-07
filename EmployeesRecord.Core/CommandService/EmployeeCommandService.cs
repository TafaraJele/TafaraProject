using EmployeesRecord.Core.Entities;
using EmployeesRecord.Core.Models;
using EmployeesRecord.Infrastructure;
using EmployeesRecord.Infrastructure.Entities;
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
       
        public string Create(Employee employee)
        {

            var employee2 = new EmployeeEntity
            {
                Department = employee.Department,
                Id = employee.Id,
                JobTitle = employee.JobTitle,
                Name = employee.Name,
                Surname = employee.Surname
            };
            employee.Id = Guid.NewGuid();

            _employeeRepository.Create(employee2);
            return employee.Id.ToString();


        }
        public string CreateInfo(HRInformation hRInformation)
        {

            var information1 = new HRInformationEntity
            {
                ECnumber = hRInformation.ECnumber,
                EmployeeCategory = hRInformation.EmployeeCategory,
                EmployeeId = hRInformation.EmployeeId,
                MedicalAidType = hRInformation.MedicalAidType,
                Salary = hRInformation.Salary,
            };


            _hrInformationRepository.CreateInfo(information1);

            return "Employee information successfully uploaded";
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












