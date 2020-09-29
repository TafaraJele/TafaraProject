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

        private readonly IMongoCollection<Employee> _employee;
        private readonly IMongoCollection<EmployeeQualification> _qualification;

        public EmployeeService(IEmployeeRepository settings)
        {

            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _employee = database.GetCollection<Employee>(settings.EmployeeCollectionName);
            _qualification = database.GetCollection<EmployeeQualification>(settings.QualificationCollectionName);


        }
        public List<Employee> GetEmployees() =>


                _employee.Find(employee => true).ToList();

        public Employee Get(Guid Id)
        {

            return _employee.Find(e => e.Id == Id).FirstOrDefault();


        }
        public Employee Create(Employee employee)

        {
            employee.Id = Guid.NewGuid();

            _employee.InsertOne(employee);


            return employee;

        }

        public List<EmployeeQualification> GetEmployeeQualifications() =>

           _qualification.Find(qualification => true).ToList();

        public EmployeeQualification Create(EmployeeQualification employeeQualification)
        {
            _qualification.InsertOne(employeeQualification);

            return employeeQualification;


        }




    }
}







