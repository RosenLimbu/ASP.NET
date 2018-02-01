using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace RosenLimbu_Lab4.Models
{
/*Author: Rosen Limbu
 * Date: January 18, 2018
 * Description: This class gets the connectionstring from the database. Also, the code for the methods to get customer data and open incidents
 * are included in this class as well.
 * */
    public class TechDB
    {

        //method to get all incidents that are currently opened
        public static List<Incidents> GetOpenTechIncidents(int TechID)
        {
            List<Incidents> incidents = new List<Incidents>(); //found incidents
            Incidents icd; //for reading
                           // define connection
            SqlConnection con = new SqlConnection(GetConnectionString());

            // define the select query command
            string selectQuery = "SELECT IncidentID, CustomerID, ProductCode, TechID, DateOpened, DateClosed, Title, Description "
                + "FROM Incidents " +
                "WHERE DateClosed is null AND TechID = @TechID";

            SqlCommand selectCommand = new SqlCommand(selectQuery, con);
            selectCommand.Parameters.AddWithValue("@TechID", TechID);
            try
            {
                // open the connection
                con.Open();

                // execute the query
                SqlDataReader reader = selectCommand.ExecuteReader();

                // process the result if any
                while (reader.Read()) // while there are customers
                {
                    icd = new Incidents();
                    icd.IncidentID = (int)reader["IncidentID"];
                    icd.CustomerID = (int)reader["CustomerID"];
                    icd.ProductCode = reader["ProductCode"].ToString();
                    if (reader["TechID"] is DBNull)
                    { icd.TechID = null; }
                    else
                    { icd.TechID = (int)reader["TechID"]; }
                    icd.DateOpened = (DateTime)reader["DateOpened"];
                    if(reader["DateClosed"] is DBNull)
                    { icd.DateClosed = null; }
                    else
                    { icd.DateClosed = (DateTime)reader["DateClosed"]; }
                    icd.Title = reader["Title"].ToString();
                    icd.Description = reader["Description"].ToString();
                    incidents.Add(icd);
                }
            }
            catch (Exception ex)
            {
                throw ex; // let the form handle it
            }
            finally
            {
                con.Close(); // close connecto no matter what
            }
            return incidents;
        }

        //method to get customer details regardingh the open incidents
        public static List<Incidents> GetCustomerIncidents(int CustomerID)
        {
            List<Incidents> custIncident = new List<Incidents>(); //found incidents
            Incidents custIcd; //for reading
                           // define connection
            SqlConnection con = new SqlConnection(GetConnectionString());

            // define the select query command
            string selectQuery = "SELECT IncidentID, CustomerID, ProductCode, DateOpened, Title, Description "
                + "FROM Incidents " +
                "WHERE CustomerID = @CustomerID";

            SqlCommand selectCommand = new SqlCommand(selectQuery, con);
            selectCommand.Parameters.AddWithValue("@CustomerID", CustomerID);
            try
            {
                // open the connection
                con.Open();

                // execute the query
                SqlDataReader reader = selectCommand.ExecuteReader();

                // process the result if any
                while (reader.Read()) // while there are customers
                {
                    custIcd = new Incidents();
                    custIcd.IncidentID = (int)reader["IncidentID"];
                    custIcd.CustomerID = (int)reader["CustomerID"];
                    custIcd.ProductCode = reader["ProductCode"].ToString();
                    custIcd.DateOpened = (DateTime)reader["DateOpened"];
                    custIcd.Title = reader["Title"].ToString();
                    custIcd.Description = reader["Description"].ToString();
                    custIncident.Add(custIcd);
                }
            }
            catch (Exception ex)
            {
                throw ex; // let the form handle it
            }
            finally
            {
                con.Close(); // close connecto no matter what
            }
            return custIncident;
        }

        //connect to database
        private static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings
                ["TechSupportConnection"].ConnectionString;
        }
    }
}