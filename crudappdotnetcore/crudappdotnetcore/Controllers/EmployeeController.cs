using crudappdotnetcore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
namespace crudappdotnetcore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public EmployeeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        [Route("GetAllEmployees")]

        public Response GetAllEmployees()
        {

            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("CrudConnection").ToString());
            Response response = new Response();

            DAL dal = new DAL();
            response = dal.GetAllEmployees(connection);
            return response;

        }

        [HttpGet]
        [Route("GetEmployeeById/{id}")]

        public Response GetEmployeeById(int id)
        {

            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("CrudConnection").ToString());
            Response response = new Response();

            DAL dal = new DAL();
            response = dal.GetEmployeeById(connection,id);
            return response;

        }

        [HttpPost]

        [Route("AddEmployee")]
        public Response AddEmployee(Employee employee)
        {
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("CrudConnection").ToString());
            Response response = new Response();
            DAL dal = new DAL();
            response = dal.AddEmployee(connection, employee);
            return response;
        }


    }



}