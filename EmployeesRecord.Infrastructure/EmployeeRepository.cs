using EmployeesRecord.Core.Entities;
using EmployeesRecord.Infrastructure.Entities;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace EmployeesRecord.Infrastructure
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly IMongoCollection<EmployeeEntity> _employee;

       
        public EmployeeRepository(Dbcontext dbcontext)
        {
           
            var client = new MongoClient(dbcontext.ConnectionString);
            var database = client.GetDatabase(dbcontext.DatabaseName);
            _employee = database.GetCollection<EmployeeEntity>(dbcontext.EmployeeCollectionName);
            
            
        }   

        public List<EmployeeEntity> GetEmployees()
        {
            return _employee.Find(employee => true).ToList();        }

       
        public string Create(EmployeeEntity employeeEntity)
        {
           _employee.InsertOne(employeeEntity);

            return "Employee successfully created";
        }
       
    }


}