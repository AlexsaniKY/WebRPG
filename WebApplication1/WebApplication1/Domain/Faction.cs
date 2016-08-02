using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebApplication1.Domain.Interfaces;
using WebApplication1.Services.DTO;

namespace WebApplication1.Domain
{
    public class Faction: IActivatable, IDbEntity

    {
        public int Id { get; set; }
        public bool Active { get; set; }
        [Required]
        public string Name { get; set; }

        public Faction(FactionDTO dto) {
            Id = dto.Id;
            Active = dto.Active;
            Name = dto.Name;
        }

        public Faction() { }
    }

    
}