using EmployeesRecord.Core.Entities;
using EmployeesRecord.Core.Models;
using EmployeesRecord.Infrastructure;
using EmployeesRecord.Infrastructure.Entities;
using System;
using System.Collections.Generic;


namespace EmployeesRecord.Core.Service
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
        public List<Employee> GetEmployees()
        {
            var employees = _employeeRepository.GetEmployees();

            var dtos = new List<Employee>();
            foreach (var employee in employees)
            {
                var dto = new Employee
                {
                    Department = employee.Department,
                    Id = employee.Id,
                    JobTitle = employee.JobTitle,
                    Name = employee.Name,
                    Surname = employee.Surname
                };
                dtos.Add(dto);
            }

            return dtos;


            // map entity to dto

        }

        //public Employee GetEmployee(Guid Id)
        //{
        //    Employee  employee = new EmployeeEntity
        //    { };
        //    return _employeeRepository.GetEmployee(Id);
        //}

        public List<EmployeeQualification> GetEmployeeQualifications()

        {

            var qualifications = _qualificationRepository.GetEmployeeQualifications();

            var dtos = new List<EmployeeQualification>();

            foreach (var qualification in qualifications)
            {

                var dto = new EmployeeQualification
                {
                    Id = qualification.Id,
                    EmployeeId = qualification.EmployeeId,
                    Name = qualification.Name,
                    Year = qualification.Year,
                    Academy = qualification.Academy

                };

                dtos.Add(dto);

            }
            return dtos;
        }


        public List<HRInformation> GetHRInformation()
        {
            var information = _hrInformationRepository.GetHRInformation();


            var dtos = new List<HRInformation>();


            foreach
            (var employeeinfo in information)
            {
                var dto = new HRInformation
                {
                    EmployeeId = employeeinfo.EmployeeId,
                    ECnumber = employeeinfo.ECnumber,
                    EmployeeCategory = employeeinfo.EmployeeCategory,
                    Salary = employeeinfo.Salary,
                    MedicalAidType = employeeinfo.MedicalAidType

                };

                dtos.Add(dto);

            }
            return dtos;


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












