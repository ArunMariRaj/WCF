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
}
