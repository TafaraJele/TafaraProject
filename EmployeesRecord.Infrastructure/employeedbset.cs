using EmployeesRecord.Core.Entities;
using EmployeesRecord.Infrastructure.Entities;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace EmployeesRecord.Infrastructure
{
    public class Employeedbset : IEmployeeRepository
    {
        private readonly IMongoCollection<EmployeeEntity> _employee;

        private readonly IMongoCollection<QualificationEntity> _qualification;

        private readonly IMongoCollection<HRInformationEntity> _hrinformation;
        public string EmployeeCollectionName { get; set; }

        public string QualificationCollectionName { get; set; }

        public string HRInformationCollectionName { get; set; }

        public string ConnectionString { get; set; }

        public string DatabaseName { get; set; }

        public Employeedbset()
        {
            var client = new MongoClient(ConnectionString);
            var database = client.GetDatabase(DatabaseName);
            _employee = database.GetCollection<EmployeeEntity>(EmployeeCollectionName);
            _qualification = database.GetCollection<QualificationEntity>(QualificationCollectionName);
            _hrinformation = database.GetCollection<HRInformationEntity>(HRInformationCollectionName);
        }

        public List<EmployeeEntity> GetEmployees()
        {
            return _employee.Find(employee => true).ToList();
        }

        public List<QualificationEntity> GetEmployeeQualifications()
        {
            return _qualification.Find(qualification => true).ToList();
        }

       // public List<HRInformationEntity> HRInformation => _hrinformation.Find(_hrinformation => true).ToList();


    }


}