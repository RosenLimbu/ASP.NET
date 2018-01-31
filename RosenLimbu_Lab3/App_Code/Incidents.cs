using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
/*Author: Rosen Limbu
 * Created: January 17th, 2018
 * Description: This is an accessor class for the incident table
 * */
public class Incidents
    {
        public int Incident { get; set; }

        public string Name { get; set; }
        public int IncidentID { get; set; }
        public int CustomerID { get; set; }
        public string ProductCode { get; set; }
        public int TechID { get; set; }
        public DateTime DateOpened { get; set; }
        public DateTime? DateClosed { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }