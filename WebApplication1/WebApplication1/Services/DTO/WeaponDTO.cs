using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Services.DTO
{
    public class WeaponDTO
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public string Name { get; set; }
        public int Damage { get; set; }
    }
}