
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace EmployeesRecord.Core.Models
{
    [DataContract]
    public class Employee
    {

      
        [DataMember (Name = "id")]
        public Guid Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "surname")]
        public string Surname { get; set; }

        [DataMember(Name = "jobTitle")]
        public string JobTitle { get; set; }

        [DataMember(Name = "department")]

        public string Department { get; set; }


    }
}
