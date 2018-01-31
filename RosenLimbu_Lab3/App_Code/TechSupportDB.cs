using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Author: Rosen Limbu
 * Created: January 17th, 2018
 * Description: This class retrieves the connection from the database via web.config
 * */
public static class TechSupportDB
    {
        public static SqlConnection GetConnection()
        {
        string connString = ConfigurationManager.ConnectionStrings["TechSupportConnection"].ConnectionString;
        SqlConnection conn = new SqlConnection(connString);
        return conn;
    }
    }
