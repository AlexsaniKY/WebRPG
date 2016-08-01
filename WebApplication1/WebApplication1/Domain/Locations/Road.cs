using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Domain.Locations
{
    public class Road: Location
    {
        public int Distance { get; set; }

        
        public int Destination1Id { get; set;}
        [ForeignKey("Destination1Id")]
        public virtual Location Destination1 { get; set; }

        
        public int Destination2Id { get; set; }
        [ForeignKey("Destination2Id")]
        public virtual Location Destination2 { get; set; }

    }
}