using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebApplication1.Domain.Interfaces;

namespace WebApplication1.Domain.Items
{
    public class Item: IActivatable, IDbEntity
    {
        public int Id { get; set; }
        public bool Active { get; set; }

        [Required]
        public string Name { get; set; }
    }
}