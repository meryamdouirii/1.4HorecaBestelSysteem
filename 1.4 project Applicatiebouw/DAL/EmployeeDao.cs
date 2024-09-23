using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Collections.Generic;

namespace DAL
{
    public class EmployeeDao : BaseDao
    {
        public List<Employee> GetAllEmployees()
        {
            string query = "SELECT Employeeid, firstname, lastname, birthdate, Salt, Hash, role from Employee";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Employee> ReadTables(DataTable dataTable)
        {
            List<Employee> employees = new List<Employee>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Employee Employee = new Employee()
                {
                    EmployeeId = (int)dr["employeeid"],
                    Firstname = dr["Firstname"].ToString(),
                    Lastname = dr["Lastname"].ToString(),
                    BirthDate = (DateTime)dr["birthdate"],
                    Salt = dr["Salt"].ToString(),
                    Hash = dr["Hash"].ToString(),
                    Role = Enum.Parse<Role>(dr["role"].ToString(), true)
                };
                employees.Add(Employee);
            }
            return employees;
        }
        public void RemoveEmployee(Employee employee)
        {
            string query = "Delete From Employee Where EmployeeId = @EmployeeId";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@EmployeeId", SqlDbType.Int);
            sqlParameters[0].Value = employee.EmployeeId;

            ExecuteEditQuery(query, sqlParameters);
        }

        public void AddEmployee(Employee employee)
        {
            string query = "INSERT INTO EMPLOYEE (FirstName, LastName, Birthdate, salt, hash, Role) " +
                   "VALUES (@Firstname, @Lastname, @Birthdate, @Salt, @Hash, @Role)";

            SqlParameter[] sqlParameters = new SqlParameter[6];
            sqlParameters[0] = new SqlParameter("@Firstname", SqlDbType.VarChar);
            sqlParameters[0].Value = employee.Firstname;
            sqlParameters[1] = new SqlParameter("@Lastname", SqlDbType.VarChar);
            sqlParameters[1].Value = employee.Lastname;
            sqlParameters[2] = new SqlParameter("@Birthdate", SqlDbType.Date);
            sqlParameters[2].Value = employee.BirthDate; // Ensure Birthdate is DateTime
            sqlParameters[3] = new SqlParameter("@Salt", SqlDbType.VarChar);
            sqlParameters[3].Value = employee.Salt;
            sqlParameters[4] = new SqlParameter("@Hash", SqlDbType.VarChar);
            sqlParameters[4].Value = employee.Hash;
            sqlParameters[5] = new SqlParameter("@Role", SqlDbType.VarChar);
            sqlParameters[5].Value = employee.Role.ToString();

            ExecuteEditQuery(query, sqlParameters);
        }

        public Employee GetEmployeeByName(string name)
        {
            string query = "SELECT Employeeid, firstname, lastname, birthdate, Salt, Hash, role from Employee where firstname = @name";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@name", SqlDbType.VarChar);
            sqlParameters[0].Value = name;
            return ReadTablesName(ExecuteSelectQuery(query, sqlParameters));
        }

        private Employee ReadTablesName(DataTable dataTable)
        {
            Employee employee = new Employee();
            if (dataTable.Rows.Count != 0)
            {
                var dr = dataTable.Rows[0];
                employee.EmployeeId = (int)dr["EmployeeId"];
                employee.Firstname = dr["Firstname"].ToString();
                employee.Lastname = dr["Lastname"].ToString();
                employee.BirthDate = (DateTime)dr["Birthdate"];
                employee.Salt = dr["Salt"].ToString();
                employee.Hash = dr["Hash"].ToString();
                employee.Role = Enum.Parse<Role>(dr["Role"].ToString(), true);
            }
            return employee;


        }
    }
}
