using Contracts;
using System;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace ConsoleClient
{
    class Program
    {
        public enum BindingTypes
        {
            BasicHttpBinding,
            WSHttpBinding,
            NetHttpBinding,
            NetTcpBinding
        }
        static void Main()
        {
            Binding binding = null;
            EndpointAddress endPoint = null;
            Console.WriteLine("Choose Binding:\n1.BasicHttpBinding\n2.WSHttpBinding\n3.NetHttpBinding\n4.NetTcpBinding");
            int choice = int.Parse(Console.ReadLine()) - 1;
            if (choice == 0)
            {
                binding = new BasicHttpBinding();
                endPoint = new EndpointAddress("http://localhost:8085/ConsoleHostTest/basichttpbinding");
            }
            else if (choice == 1)
            {
                binding = new WSHttpBinding();
                endPoint = new EndpointAddress("http://localhost:8085/ConsoleHostTest/wshttpbinding");
            }
            else if (choice == 2)
            {
                binding = new NetHttpBinding();
                endPoint = new EndpointAddress("http://localhost:8085/ConsoleHostTest/nethttpbinding");
            }
            else if (choice == 3)
            {
                binding = new NetTcpBinding();
                endPoint = new EndpointAddress("net.Tcp://localhost:8086/ConsoleHostTest/nettcpbinding");
            }
            IEmployeeOperations proxy = ChannelFactory<IEmployeeOperations>.CreateChannel(binding, endPoint);

            Employee employee = new Employee { EmployeeName = "Arun", EmployeePay = "30k", EmployeeRole = "SoftwareEngineer" };
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
