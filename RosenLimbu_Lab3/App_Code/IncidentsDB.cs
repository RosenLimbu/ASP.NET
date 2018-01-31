using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
/*Author: Rosen Limbu
 * Created: January 17th, 2018
 * Description: This class connects to the database and selects the appropriate column
 * */

[DataObject(true)]
public class IncidentsDB
{
    [DataObjectMethod(DataObjectMethodType.Select)]
    // retrieves customer from a given state
    public static List<Incidents> GetOpenTechIncidents(string TechID)
    {
        List<Incidents> incidents = new List<Incidents>(); //found incidents
        Incidents icd; //for reading
                       // define connection
        SqlConnection connection = TechSupportDB.GetConnection();

        // define the select query command
        string selectQuery = "SELECT c.Name, i.IncidentID, i.ProductCode, c.CustomerID, i.TechID, i.DateOpened, i.Title, i.Description " +
                             "FROM Incidents as i " +
                             "INNER JOIN Customers as c on i.CustomerID = c.CustomerID " +
                             "WHERE TechID = @TechID AND i.DateClosed is null ";

        SqlCommand selectCommand = new SqlCommand(selectQuery, connection);
        selectCommand.Parameters.AddWithValue("@TechID", TechID);
        try
        {
            // open the connection
            connection.Open();

            // execute the query
            SqlDataReader reader = selectCommand.ExecuteReader();

            // process the result if any
            while (reader.Read()) // while there are customers
            {
                icd = new Incidents();
                icd.Name = reader["Name"].ToString();
                icd.IncidentID = (int)reader["IncidentID"];
                icd.CustomerID = (int)reader["CustomerID"];
                icd.ProductCode = reader["ProductCode"].ToString();
                icd.TechID = (int)reader["TechID"];
                icd.DateOpened = (DateTime) reader["DateOpened"];
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
            connection.Close(); // close connecto no matter what
        }
        return incidents;
    }
}