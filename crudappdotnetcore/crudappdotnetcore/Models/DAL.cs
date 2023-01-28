using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace crudappdotnetcore.Models
{
    public class DAL
    {

        public Response GetAllEmployees(SqlConnection connection) {

            Response response = new Response();
            SqlDataAdapter da = new SqlDataAdapter("Select * from tblCrudNetCore",connection);
            DataTable dt = new DataTable();
            List<Employee> lstEmployees = new List<Employee>();

            da.Fill(dt);
            if (dt.Rows.Count > 0) { 
                 

                for(int i=0; i < dt.Rows.Count; i++)
                {

                    Employee employee = new Employee();
                    employee.Id = Convert.ToInt32(dt.Rows[i]["Id"]);
                    employee.Name = Convert.ToString(dt.Rows[i]["Name"]);
                    employee.Email = Convert.ToString(dt.Rows[i]["Email"]);
                    employee.IsActive = Convert.ToInt32(dt.Rows[i]["IsActive"]);
                    lstEmployees.Add(employee);
                }
                if (lstEmployees.Count > 0)
                {
                    response.StatusCode = 200;
                    response.StatusMessage = "Data found";
                    response.listemployee = lstEmployees;

                }
                else {

                    response.StatusCode = 100;
                    response.StatusMessage = "No data Found";
                    response.listemployee = null;


                }
            }
            return response;




                }

        public Response GetEmployeeById(SqlConnection connection, int id)
        {

            Response response = new Response();
            SqlDataAdapter da = new SqlDataAdapter("Select * from tblCrudNetCore WHERE ID= '"+id+"'", connection);
            DataTable dt = new DataTable();
            Employee Employees = new Employee();

            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {


             
               

                    Employee employee = new Employee();
                    employee.Id = Convert.ToInt32(dt.Rows[0]["Id"]);
                    employee.Name = Convert.ToString(dt.Rows[0]["Name"]);
                    employee.Email = Convert.ToString(dt.Rows[0]["Email"]);
                    employee.IsActive = Convert.ToInt32(dt.Rows[0]["IsActive"]);
                    response.StatusCode = 200;
                    response.StatusMessage = "Data found";
                    response.Employee = employee;
                
            }
            else
            {

                response.StatusCode = 100;
                response.StatusMessage = "No data Found";
                response.Employee = null;


            }
            
            return response;




        }
        public Response AddEmployee(SqlConnection connection, Employee employee)
        {

            Response response = new Response();
            SqlCommand cmd = new SqlCommand("Insert Into tblCrudNetCore(Name,Email,IsActive,CreatedOn) Values('"+employee.Name+"','"+employee.Email+ "','"+employee.Name+ "','"+employee.IsActive+"',GETDATE()", connection);
            connection.Open();
            int i = cmd.ExecuteNonQuery();
            connection.Close();
      
            if (i > 0)
            {

                response.StatusCode = 200;
                response.StatusMessage = "Employee added";

            }
            else
            {

                response.StatusCode = 100;
                response.StatusMessage = "No data Inserted";
              


            }

            return response;




        }

    }
}
