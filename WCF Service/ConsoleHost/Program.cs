using Host;
using System;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            WebServiceHost consoleHostWeb = new WebServiceHost(typeof(RestfulEmployeeOperations));
            ServiceHost consoleHost = new ServiceHost(typeof(EmployeeOperations));
            consoleHostWeb.Open();
            consoleHost.Open();
            Console.WriteLine("Server Started ...");
            Console.WriteLine("Press a Key to Terminate ...");
            Console.ReadLine();
            Console.WriteLine("Server ShutDown ...");
            consoleHost.Close();
            consoleHostWeb.Close();
        }
    }
}
