using Contracts;
using System.Collections.Generic;
using System.Linq;

namespace ServiceImplementation
{
    public class ServiceImplementationLogic
    {
        private static int _id = 10000;
        private static List<Employee> EmployeeList = new List<Employee>();
        public ServiceImplementationLogic()
        {
            EmployeeList.Add(new Employee { EmployeeId=_id, EmployeeName="Test", EmployeePay="Less Pay", EmployeeRole="SoftwareEngineer" });
        }
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
                return EmployeeList.Where(x => x.EmployeeId == Id).FirstOrDefault();
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
                if(!EmployeeList.Exists(x => x.EmployeeId == Id))
                    return true;
            }
            return false;
        }
    }
}
