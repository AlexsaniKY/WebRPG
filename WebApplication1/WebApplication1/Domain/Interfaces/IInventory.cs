﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Domain.Items;

namespace WebApplication1.Domain.Interfaces
{
    public interface IInventory
    {
        ICollection<Item> Items { get; set; }
    }
}
