using EmployeesRecord.Core.Models;
using EmployeesRecord.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeRecordQuery.Core.QueryService
{
    public class EmployeeQueryService
    { {

        private readonly IEmployeeRepository _employeeRepository;
        private readonly IQualificationRepository _qualificationRepository;
        private readonly IHRInformationRepository _hrInformationRepository;


        public EmployeeQueryService(IEmployeeRepository employeeRepository, IQualificationRepository qualificationRepository, IHRInformationRepository hrInformationRepository)
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

    }
}
