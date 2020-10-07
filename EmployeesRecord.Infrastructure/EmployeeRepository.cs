﻿using EmployeesRecord.Core.Entities;
using EmployeesRecord.Infrastructure.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public async Task<List<EmployeeEntity>> GetEmployees()
        {
            //FilterDefinition<EmployeeEntity> filter = Builders<EmployeeEntity>.Filter.Empty;
            // var result = (await _employee.FindAsync(filter)).ToList();
          var result =  (await _employee.FindAsync(employee => true)).ToList();
            return result;
        }

        //public EmployeeEntity GetEmployee(Guid Id)
            
        //{
        //    FilterDefinition<HRInformationEntity> filter = Builders<HRInformationEntity>.Filter.Eq("_id", Id);
        //    return _employee.Find(c => c.Id == Id).FirstOrDefault();
        //}

       
        public string Create(EmployeeEntity employeeEntity)
        {
           _employee.InsertOne(employeeEntity);

            return "Employee successfully created";
        }
       public string UpdateEmployee(Guid Id, EmployeeEntity employeeEntity)
        {

         //  _employee.ReplaceOne(c => c.Id ==Id,employeeEntity);
            FilterDefinition<EmployeeEntity> filter = Builders<EmployeeEntity>.Filter.Eq("_id", Id);

            _employee.ReplaceOneAsync(filter, employeeEntity);
            return "";
        }

        public string DeleteEmployee(Guid Id)
        {

            FilterDefinition<EmployeeEntity> filter = Builders<EmployeeEntity>.Filter.Eq("_id", Id);

                _employee.DeleteOneAsync(filter);
            return "Employee successfully removed";
        }
    }


}