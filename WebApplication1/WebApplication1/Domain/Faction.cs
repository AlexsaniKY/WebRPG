﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Domain.Interfaces;

namespace WebApplication1.Domain
{
    public class Faction: IActivatable, IDbEntity

    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public string Name { get; set; }
    }
}