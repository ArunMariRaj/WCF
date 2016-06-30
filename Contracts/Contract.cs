using System.Runtime.Serialization;
using System.ServiceModel;

namespace Contracts
{
    [DataContract]
    public class Employee
    {
        [DataMember(EmitDefaultValue =true)]
        public int EmployeeId = 0;
        [DataMember]
        public string EmployeeName { get; set; }
        [DataMember]
        public string EmployeeRole { get; set; }
        [DataMember]
        public string EmployeePay { get; set; }
    }
    [ServiceContract]
    public interface IEmployeeOperations
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
