using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Domain.Locations
{
    public class Building
    {
        [ForeignKey("ParentCity")]
        public int CityId { get; set; }
        public virtual City ParentCity { get; set; }

    }
}