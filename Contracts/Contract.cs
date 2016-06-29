using System.Runtime.Serialization;
using System.ServiceModel;

namespace Contracts
{
    [DataContract]
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeRole { get; set; }
        public string EmployeePay { get; set; }
    }
    [ServiceContract]
    interface IEmployeeOperations
    {
        [OperationContract]
        bool AddEmployee(Employee employee);
        [OperationContract]
        Employee ViewEmployee(int Id);
        [OperationContract]
        bool EditEmployee(Employee employee);
        [OperationContract]
        bool RemoveEmployee(int Id);
    }
}
