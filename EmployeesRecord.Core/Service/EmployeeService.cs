using EmployeesRecord.Core.Models;
using EmployeesRecord.Infrastructure;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;


namespace EmployeesRecord.Core.Service
{
    public class EmployeeService : IEmployeeService
    {

       
        private readonly IMongoCollection<EmployeeQualification> _qualification;
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository  employeeRepository)
        {

            _employeeRepository = employeeRepository;
         //   _qualification = database.GetCollection<EmployeeQualification>(settings.QualificationCollectionName);


        }
        public List<Employee> GetEmployees()
        {
            var employees = _employeeRepository.GetEmployees();

           
            
            // map entity to dto
            return employees;
        }

        public List<EmployeeQualification> GetEmployeeQualifications()

        {

           var qualifications = _qualification.GetEmployeeQualifications();

            return qualifications;
        }



        public Employee Get(Guid Id)
        {
            var employees = _employeeRepository.GetEmployees();

            return employee;


        }
        public Employee Create(Employee employee)

        {
            employee.Id = Guid.NewGuid();

            _employee.InsertOne(employee);


            return employee;

        }

       // public List<EmployeeQualification> GetEmployeeQualifications()
       // {            return _qualification.Find(qualification => true).ToList();     }

           

        //public EmployeeQualification Create(EmployeeQualification employeeQualification)
        //{
        //   var qualifications = _qualification.InsertOne(employeeQualification);

        //    return qualifications;


        //}




    }
}







