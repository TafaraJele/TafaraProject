using EmployeesRecord.Infrastructure.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeesRecord.Infrastructure
{
    public class QualificationRepository: IQualificationRepository
    {
        private readonly IMongoCollection<QualificationEntity> _qualification;
       // public string EmployeeCollectionName { get; set; }

        //public string QualificationCollectionName { get; set; }

       // public string ConnectionString { get; set; }

        //public string DatabaseName { get; set; }

        private readonly Dbcontext _dbcontext;
        public QualificationRepository(Dbcontext dbcontext)
        {
            _dbcontext = dbcontext;
            var client = new MongoClient(_dbcontext.ConnectionString);
            var database = client.GetDatabase(_dbcontext.DatabaseName);
            _qualification = database.GetCollection<QualificationEntity>(_dbcontext.QualificationCollectionName);
        }
        public List<QualificationEntity> GetEmployeeQualifications()
        {
            return _qualification.Find(qualification => true).ToList();
        }






    }
}
