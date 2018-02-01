using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RosenLimbu_Lab4
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IIncidentsService" in both code and config file together.
    [ServiceContract]
    //all methods in the interface must be called
    public interface IIncidentsService
    {
        [OperationContract]
        List<Incidents> GetOpenTechIncidents(int TechID);
        [OperationContract]
        List<Incidents> GetCustomerIncidents(int CustomerID);
        [OperationContract]
        List<int> GetAllCustomerID();

    }

    //accessor class for the data members
    public class Incidents
    {
        [DataMember]
        public int IncidentID { get; set; }
        [DataMember]
        public int CustomerID { get; set; }
        [DataMember]
        public string ProductCode { get; set; }
        [DataMember]
        public int? TechID { get; set; }
        [DataMember]
        public DateTime DateOpened { get; set; }
        [DataMember]
        public DateTime? DateClosed { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string Description { get; set; }
    }
}
