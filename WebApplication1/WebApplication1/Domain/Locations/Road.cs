using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Domain.Locations
{
    public class Road
    {
        public int Distance { get; set; }

        [ForeignKey("Destination1")]
        public int Destination1Id { get; set;}
        public virtual Location Destination1 { get; set; }

        [ForeignKey("Destination2")]
        public int Destination2Id { get; set; }
        public virtual Location Destination2 { get; set; }

    }
}