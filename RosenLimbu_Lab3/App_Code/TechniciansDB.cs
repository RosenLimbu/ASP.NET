using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Author: Rosen Limbu
 * Created: January 17th, 2018
 * Description: This class connects to the database and selects the appropriate column
 * */
[DataObject(true)]
public static class TechnicianDB
    {
    [DataObjectMethod(DataObjectMethodType.Select)] //the select method is used
    public static List<Technicians> GetAllTechnicians()
        {
            List<Technicians> tech = new List<Technicians>(); // make an empty list
            Technicians tch; // reference to new state object
            // create connection
            SqlConnection connection = TechSupportDB.GetConnection();

            // create select command
            string selectString = "select TechId, Name, Email, Phone from Technicians " +
                                  "order by Name";
            SqlCommand selectCommand = new SqlCommand(selectString, connection);
            try
            {
                // open connection
                connection.Open();
                // run the select command and process the results adding states to the list
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    tch = new Technicians();
                    tch.TechID = (int) reader["TechId"];
                    tch.Name = reader["Name"].ToString();
                    tech.Add(tch);
                }
                //reader.Close();
            }
            catch (Exception ex)
            {
                throw ex; // throw it to the form to handle
            }
            finally
            {
                connection.Close();
            }
            return tech;
        }
    }