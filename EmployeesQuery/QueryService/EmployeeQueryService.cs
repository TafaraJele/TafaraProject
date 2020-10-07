using EmployeesQuery.QueryService;
using EmployeesRecord.Core.Models;
using EmployeesRecord.Infrastructure;
using EmployeesRecordCommand.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeQuery.QueryService
{
    public class EmployeeQueryService: IEmployeeQueryService
    { 

        private readonly IEmployeeRepository _employeeRepository;
        private readonly IQualificationRepository _qualificationRepository;
        private readonly IHRInformationRepository _hrInformationRepository;


        public EmployeeQueryService(IEmployeeRepository employeeRepository, IQualificationRepository qualificationRepository, IHRInformationRepository hrInformationRepository)
        {

            _employeeRepository = employeeRepository;
            _qualificationRepository = qualificationRepository;
            _hrInformationRepository = hrInformationRepository;

        }
        public async Task<List<Employee>> GetEmployees()
        {
            var employees = await _employeeRepository.GetEmployees();

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

        //public Employee GetEmployee(Guid Id)
        //{
        //    Employee  employee = new EmployeeEntity
        //    { };
        //    return _employeeRepository.GetEmployee(Id);
        //}
        
        

        //public Employee GetEmployee(Guid Id)
        //{
        //    Employee  employee = new EmployeeEntity
        //    { };
        //    return _employeeRepository.GetEmployee(Id);
        //}

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


        public async Task<List<HRInformation>> GetHRInformation()
        {
            var information = await _hrInformationRepository.GetHRInformation();


            var dtos = new List<HRInformation>();


            foreach
            (var employeeinfo in information)
            {
                var dto = new HRInformation
                {
                    EmployeeId = employeeinfo.EmployeeId,
                    ECnumber = employeeinfo.ECnumber,
                    EmployeeCategory = employeeinfo.EmployeeCategory,
                    Salary = employeeinfo.Salary,
                    MedicalAidType = employeeinfo.MedicalAidType

                };

                dtos.Add(dto);

            }
            return dtos;


        }


    }
}
