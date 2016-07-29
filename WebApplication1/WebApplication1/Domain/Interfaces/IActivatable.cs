using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Domain.Interfaces
{
    public interface IActivatable
    {
        bool Active { get; set; }
    }
}