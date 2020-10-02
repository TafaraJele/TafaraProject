using EmployeesRecord.Core.Models;
using EmployeesRecord.Infrastructure;
using System.Collections.Generic;


namespace EmployeesRecord.Core.Service
{
    public class EmployeeService : IEmployeeService
    {


        //private readonly IMongoCollection<EmployeeQualification> _qualification;
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IQualificationRepository _qualificationRepository;




        public EmployeeService(IEmployeeRepository employeeRepository, IQualificationRepository qualificationRepository)
        {

            _employeeRepository = employeeRepository;
            _qualificationRepository = qualificationRepository;
            //   _qualification = database.GetCollection<EmployeeQualification>(settings.QualificationCollectionName);


        }
        public List<Employee> GetEmployees()
        {
            var employees = _employeeRepository.GetEmployees();

            var dtos = new List<Employee>();
            foreach (var employee in employees)
            {
                var dto = new Employee
                {
                    Department = employee.Department,
                    Id = employee.Id,
                    JobTitle = employee.JobTitle,
                    Name = employee.Name,
                    Surname = employee.Surname
                };
                dtos.Add(dto);
            }

            return dtos;


            // map entity to dto

        }

        public List<EmployeeQualification> GetEmployeeQualifications()

        {

            var qualifications = _qualificationRepository.GetEmployeeQualifications();

            var dtos = new List<EmployeeQualification>();

            foreach (var qualification in qualifications)
            {

                var dto = new EmployeeQualification
                {
                    Id = qualification.Id,
                    EmployeeId = qualification.EmployeeId,
                    Name = qualification.Name,
                    Year = qualification.Year,
                    Academy = qualification.Academy

                };

                dtos.Add(dto);

            }
            return dtos;
        }



        //public Employee Get(Guid Id)
        //{
        //    var employee = _employeeRepository.GetEmployees();


        //    return employee;


        //}
        //public Employee Create(Employee employee)

        //{
        //    employee.Id = Guid.NewGuid();

        //    var employee1 = _employeeRepository.Create();

        //    return employee1;

    }

    // public List<EmployeeQualification> GetEmployeeQualifications()
    // {            return _qualification.Find(qualification => true).ToList();     }



    //public EmployeeQualification Create(EmployeeQualification employeeQualification)
    //{
    //   var qualifications = _qualification.InsertOne(employeeQualification);

    //    return qualifications;


    //}




}








