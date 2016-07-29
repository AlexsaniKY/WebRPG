﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using WebApplication1.Domain.Interfaces;

namespace WebApplication1.Domain.Locations
{
    public class Location : IActivatable, IDbEntity
    {
        public int Id { get; set; }
        public bool Active{ get; set;}

        [Required]
        public string Name { get; set; }

        [ForeignKey("ParentCountry")]
        public int CountryId { get; set; }
        public virtual Country ParentCountry { get; set; }

    }
}