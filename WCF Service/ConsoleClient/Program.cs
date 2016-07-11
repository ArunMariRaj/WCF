using ConsoleClient.BindingImplementations;
using ConsoleClient.SimpleFactory;
using Contracts;
using System;
using System.ServiceModel;

namespace ConsoleClient
{
    class Program
    {
        static void Main()
        {
            //Get user input to select the Type of Binding
            Console.WriteLine("Choose Binding:\n1.BasicHttpBinding\n2.WSHttpBinding\n3.NetHttpBinding\n4.NetTcpBinding");
            int choice = int.Parse(Console.ReadLine()) - 1;

            //Calling the Simple Factory to create object of the required Binding
            AbstractSoapClientBindings clientBindings = SimpleBindingFactory.GetBindingFactory((BindingTypes)choice);

            //Calling the client by creating a proxy using the slected binding
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
