using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace Api_connection.Controllers
{// start of namespace
    //post request method to store user information
    //from fullname, email and password
    [Route("api/[controller]")]
    [ApiController]
    public class store_info 
    {
        [HttpPost]
        public string store_userinfo(string fullname, string email, string password)
        {//start of method

            // temp message
            string message = "";


            //try and catch
            try
            {
                //connection string
                string connection_string = @"Datasource=(localdb)\api_endpoint;database=testing_api,";

                //create connection
                SqlConnection connect = new SqlConnection(connection_string);

                //open connection
                connect.Open();

                //Query
                string query = @"INSERT INTO users Values('"+fullname+"','"+email+"','"+password+"');";

                //run query
                //using SqlCommand to execute the query
                SqlCommand run_query = new SqlCommand(query, connect);

                //run OR execute the query
                run_query.ExecuteNonQuery();

                //Return a message
                message = "User information stored successfully";

                //close connection
                connect.Close();

            }//end of try
            catch (Exception error)
            {
                //start of catch


            }//end of catch



            return "it works";


        }//end of store_userinfo method
    }//end of class
}//end of namespace}