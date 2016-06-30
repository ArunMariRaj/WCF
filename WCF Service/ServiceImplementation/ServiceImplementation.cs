using Contracts;
using System.Collections.Generic;
using System.Linq;

namespace ServiceImplementation
{
    public class ServiceImplementationLogic
    {
        private static int _id = 10000;
        private static List<Employee> EmployeeList = new List<Employee>();
        public bool AddingAnEmployee(Employee employee)
        {
            _id++;
            Employee employeeToBeAdded = new Employee
            {
                EmployeeId = _id,
                EmployeeName = employee.EmployeeName,
                EmployeeRole = employee.EmployeeRole,
                EmployeePay = employee.EmployeePay
            };
            EmployeeList.Add(employeeToBeAdded);
            if (EmployeeList.Contains(employeeToBeAdded))
            {
                return true;
            }
            else return false;
        }
        public Employee viewingAnEmployee(int Id)
        {
            if(EmployeeList.Exists(x => x.EmployeeId == Id))
            {
                return EmployeeList.Select(x => x.EmployeeId == Id) as Employee;
            }
            return null;
        }
        public bool EditingAnEmployee(Employee employee)
        {
            if (EmployeeList.Exists(x=>x.EmployeeId==employee.EmployeeId))
            {
                EmployeeList.RemoveAll(x => x.EmployeeId == employee.EmployeeId);
                EmployeeList.Add(employee);
                return true;
            }
            return false;
        }
        public bool RemovingAnEmployee(int Id)
        {
            if (EmployeeList.Exists(x => x.EmployeeId == Id))
            {
                EmployeeList.RemoveAll(x => x.EmployeeId == Id);
                return true;
            }
            return false;
        }
    }
}
