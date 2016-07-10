using Contracts;
using System;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace ConsoleClient
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Choose Binding:\n1.BasicHttpBinding\n2.WSHttpBinding\n3.NetHttpBinding\n4.NetTcpBinding");
            int choice = int.Parse(Console.ReadLine()) - 1;

            ClientBindings clientBindings = BindingFactory.GetBindingFactory((BindingTypes)choice);
            IEmployeeOperations proxy = ChannelFactory<IEmployeeOperations>.CreateChannel(clientBindings.BindingType, clientBindings.EndPoint);

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
