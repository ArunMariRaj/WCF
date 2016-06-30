using Host;
using System;
using System.ServiceModel;

namespace ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost consoleHost = new ServiceHost(typeof(EmployeeOperations));
            consoleHost.Open();
            Console.WriteLine("Server Started ...");
            Console.WriteLine("Press a Key to Terminate ...");
            Console.ReadLine();
            Console.WriteLine("Server ShutDown ...");
            consoleHost.Close();
        }
    }
}
