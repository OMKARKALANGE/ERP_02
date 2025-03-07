using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Erp_02.Models
{
    public class NuserContext:DbContext
    {
       public DbSet<Nuser> Nusers { get; set; }
    }
}