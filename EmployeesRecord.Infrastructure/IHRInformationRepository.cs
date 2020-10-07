using EmployeesRecord.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesRecord.Infrastructure
{
    public interface IHRInformationRepository
    {


        Task<List<HRInformationEntity>> GetHRInformation();

        string CreateInfo(HRInformationEntity hRInformation);

        string EditEmployeeInfo(Guid Id, HRInformationEntity hRInformation);

        void DeleteInformation(Guid id);

    }
}
