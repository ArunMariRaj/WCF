using Contracts;
using System;
using System.ServiceModel;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            WSHttpBinding binding = new WSHttpBinding();
            EndpointAddress endPoint = new EndpointAddress("http://localhost:8085/ConsoleHostTest/serviceAddress");
            IEmployeeOperations proxy = ChannelFactory<IEmployeeOperations>.CreateChannel(binding, endPoint);

            Employee employee = new Employee { EmployeeName = "Arun", EmployeePay = "40k", EmployeeRole = "SoftwareEngineer" };
            bool isAdded = proxy.AddEmployee(employee);
            if (isAdded)
            {
                var exp = proxy.ViewEmployee(10001) as Employee;
                Console.WriteLine("Name: {0}, Designation: {1}", exp.EmployeeName, exp.EmployeeRole);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Not Added");
            }
        }
    }
}
