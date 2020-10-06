using EmployeesRecord.Infrastructure.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeesRecord.Infrastructure
{
   public class HRInformationRepository: IHRInformationRepository
    {

        public readonly IMongoCollection<HRInformationEntity> _information;        
        

        public HRInformationRepository(Dbcontext dbcontext)
        {
            var client = new MongoClient(dbcontext.ConnectionString);
            var database = client.GetDatabase(dbcontext.DatabaseName);
            _information = database.GetCollection<HRInformationEntity>(dbcontext.HRInformationCollectionName);
        }

        public List<HRInformationEntity> GetHRInformation()
        {
            return _information.Find(information => true).ToList();
        }

        public string CreateInfo(HRInformationEntity hRInformation)
        {
            _information.InsertOne(hRInformation);

            return "Employee information successfully uploaded";

        }

        public string EditEmployeeInfo(Guid Id, HRInformationEntity hRInformation)

        {
            FilterDefinition<HRInformationEntity> filter = Builders<HRInformationEntity>.Filter.Eq("_id", Id);

            _information.ReplaceOneAsync(filter, hRInformation);
            return "";
        }
        public void DeleteInformation(Guid id)
        {
            FilterDefinition<HRInformationEntity> filter = Builders<HRInformationEntity>.Filter.Eq("_id", id);
            _information.DeleteOneAsync(filter);
        }



    }
}
