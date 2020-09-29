using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace EmployeesRecord.Core.Models
{
    [DataContract]
    public class EmployeeQualification
    {

        [DataMember(Name = "id")]
        public Guid Id { get; set; }

        [Required]
        [DataMember (Name = "employeeId")]            
         public Guid EmployeeId { get; set; }
        

        [DataMember (Name ="name")]
        public string Name { get; set; }

        [DataMember (Name = "year")]
        public int Year { get; set; }

        [DataMember  (Name = "academy")]
        public string Academy { get; set; }

    }
}
