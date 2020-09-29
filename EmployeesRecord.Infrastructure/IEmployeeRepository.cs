namespace EmployeesRecord.Infrastructure
{
    public interface IEmployeeRepository
    {

        string EmployeeCollectionName { get; set; }

        string QualificationCollectionName { get; set; }

        string ConnectionString { get; set; }

        string DatabaseName { get; set; }

    }
}

