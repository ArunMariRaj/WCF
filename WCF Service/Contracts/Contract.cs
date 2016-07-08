using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;

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
    [ServiceContract()]
    public interface IRestfulEmployeeOperations
    {
        [OperationContract]
        [WebInvoke(Method ="POST", UriTemplate ="InsertEmployee")]
        bool AddEmployee(Employee employee);
        [OperationContract]
        [WebGet(UriTemplate ="ViewEmployee/{Id}",ResponseFormat=WebMessageFormat.Json)]
        Employee ViewEmployee(string Id);
        [OperationContract]
        [WebInvoke(Method ="PUT", UriTemplate ="UpdateEmployee")]
        bool EditEmployee(Employee employee);
        [OperationContract()]
        [WebInvoke(Method ="DELETE", UriTemplate ="DeleteEmployee/{Id}")]
        bool RemoveEmployee(string Id);
    }
}
