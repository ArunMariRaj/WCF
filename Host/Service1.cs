using Contracts;
using ServiceImplementation;
using System;

namespace Host
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
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
}
