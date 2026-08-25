using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Api_connection.Controllers
{// start of namespace
    [Route("api/[controller]")]
    [ApiController]
    public class ConnectionController : ControllerBase
    {
        //Post request method to do the connection to the database  
        [HttpPost]
        public string db_connection()
        { //start of db_connection method
          //Connection string to connect to the database  
            string message = "";

            try
            { //start of try
                string connection_string = @"Datasource=(localdb)\api_endpoint;database=testing_api,";

                SqlConnection connect = new SqlConnection(connection_string);

                connect.Open();
                message = "Connection to the database is successful";
            }// end of try
            catch(Exception error)
            { //start of catch
                message = error.Message;
            }//end of catch
            return message;
        }//end of db_connection method
    }//end of class
}//end of namespace
