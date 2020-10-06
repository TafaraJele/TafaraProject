using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace EmployeesRecord.Core.Models
{
    [DataContract]
    public class HRInformation
    {
        
        [DataMember (Name = "employeeId")]

        [Required]
        public Guid EmployeeId  {get; set;}
        
        [DataMember(Name = "ecNumber")]
        public int ECnumber { get; set; }

        [DataMember(Name = "salary")]
        public int Salary { get; set; }

        [DataMember(Name = "medicalAidType")]
        public int MedicalAidType { get; set; }

        [DataMember(Name = "employeeCategory")]
        public string EmployeeCategory { get; set; }


    }
}
