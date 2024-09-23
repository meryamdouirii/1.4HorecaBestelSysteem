using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace Service
{
    public class EmployeeService
    {
        private EmployeeDao EmployeeDB;

        public EmployeeService()
        {
            EmployeeDB = new EmployeeDao();
        }

        public List<Employee> GetEmployees()
        {
            return EmployeeDB.GetAllEmployees();
        }

        public void RemoveEmployee(Employee employee)
        {
            EmployeeDB.RemoveEmployee(employee);
        }

        public void AddEmployee(Employee employee)
        {
            EmployeeDB.AddEmployee(employee);
        }
        public Employee GetEmployeeByName(string name)
        {
            return EmployeeDB.GetEmployeeByName(name);
        }
    }
}
