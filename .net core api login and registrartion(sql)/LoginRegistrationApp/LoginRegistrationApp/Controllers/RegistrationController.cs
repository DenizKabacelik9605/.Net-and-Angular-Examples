using LoginRegistrationApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;

namespace LoginRegistrationApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {

        private readonly IConfiguration _configuration;

        public RegistrationController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [HttpPost]
        [Route("registration")]

        public string registration(Registration registration)
        {


            SqlConnection con = new SqlConnection(_configuration.GetConnectionString("ToysCon").ToString());
            SqlCommand cmd = new SqlCommand("Insert Into Registration(UserName,Password,Email,IsActivate) VALUES('" + registration.UserName + "','" + registration.Password + "','" + registration.Email + "','" + registration.IsActivate + "'  )", con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i > 0)
            {
                return "Data inserted";

            }
            else
            {
                return "Error";
            }



            return "";
        }



        [HttpPost]
        [Route("login")]

        public string login(Registration registration)
        {


            SqlConnection con = new SqlConnection(_configuration.GetConnectionString("ToysCon").ToString());
            SqlDataAdapter da = new SqlDataAdapter("select * from Registration where Email='"+registration.Email+"' AND Password='"+registration.Password+"' AND IsActivate=1", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {

                return "Valid User";
            }
            else {
                return "Invalid User";
            }

        }

    }
}