using EmployeesRecord.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeesRecord.Infrastructure
{
    public interface IHRInformationRepository
    {


        List<HRInformationEntity> GetHRInformation();

        string CreateInfo(HRInformationEntity hRInformation);

        string EditEmployeeInfo(Guid Id, HRInformationEntity hRInformation);

        void DeleteInformation(Guid id);

    }
}
