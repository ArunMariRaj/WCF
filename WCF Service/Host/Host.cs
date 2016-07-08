using System;
using Contracts;
using ServiceImplementation;

namespace Host
{
    public class EmployeeOperations : IEmployeeOperations
    {
        private readonly ServiceImplementationLogic _serviceImplementation;
        public EmployeeOperations()
        {
            _serviceImplementation = new ServiceImplementationLogic();
        }
        public bool AddEmployee(Employee employee)
        {
            return _serviceImplementation.AddingAnEmployee(employee);
        }

        public bool EditEmployee(Employee employee)
        {
            return _serviceImplementation.EditingAnEmployee(employee);
        }

        public bool RemoveEmployee(int Id)
        {
            return _serviceImplementation.RemovingAnEmployee(Id);
        }

        public Employee ViewEmployee(int Id)
        {
            return _serviceImplementation.viewingAnEmployee(Id);
        }
    }

    public class RestfulEmployeeOperations : IRestfulEmployeeOperations
    {
        private readonly ServiceImplementationLogic _serviceImplementation;
        public RestfulEmployeeOperations()
        {
            _serviceImplementation = new ServiceImplementationLogic();
        }
        public bool AddEmployee(Employee employee)
        {
            return _serviceImplementation.AddingAnEmployee(employee);
        }

        public bool EditEmployee(Employee employee)
        {
            return _serviceImplementation.EditingAnEmployee(employee);
        }

        public bool RemoveEmployee(string Id)
        {
            return _serviceImplementation.RemovingAnEmployee(int.Parse(Id));
        }

        public Employee ViewEmployee(string Id)
        {
            return _serviceImplementation.viewingAnEmployee(int.Parse(Id));
        }
    }
}
