using RosenLimbu_Lab4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RosenLimbu_Lab4
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "IncidentsService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select IncidentsService.svc or IncidentsService.svc.cs at the Solution Explorer and start debugging.
    public class IncidentsService : IIncidentsService
    {

        public List<Incidents> GetOpenTechIncidents(int TechID)
        {
            return TechDB.GetOpenTechIncidents(TechID);
        }

        public List<Incidents> GetCustomerIncidents(int CustomerID)
        {
            return TechDB.GetCustomerIncidents(CustomerID);
        }

        public List<int> GetAllCustomerID()
        {
            return Customer.GetAllCustomerID();
        }

       
    }
}
