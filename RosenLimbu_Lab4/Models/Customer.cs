using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
/*Author: Rosen Limbu
 * Date: January 18, 2018
 * Description: gets the customerIDs of all the customer from the Incident's table
 */
namespace RosenLimbu_Lab4.Models
{
    public class Customer
    {
        
        public static List<int> GetAllCustomerID()
        {
            List<int> CustomerIDs = new List<int>(); // make an empty list
            //Incidents cust; // reference to new state object
                           // create connection
            SqlConnection con = new SqlConnection(GetConnectionString());

            // create select command
            string selectString = "select distinct(CustomerID) FROM Incidents ";  //unique IDs
            SqlCommand selectCommand = new SqlCommand(selectString, con);
            try
            {
                // open connection
                con.Open();
                // run the select command and process the results adding states to the list
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    int custid;
                    custid= (int)reader["CustomerID"];
                    CustomerIDs.Add(custid);
                }
            }
            catch (Exception ex)
            {
                throw ex; // throw it to the form to handle
            }
            finally
            {
                con.Close();
            }
            return CustomerIDs;
        }

        //connection to database
        private static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings
                ["TechSupportConnection"].ConnectionString;
        }
    }
}
