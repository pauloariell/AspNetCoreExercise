using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebAspNetCore.Models
{
    public class WebAspNetCoreContext : DbContext
    {
        public WebAspNetCoreContext (DbContextOptions<WebAspNetCoreContext> options)
            : base(options)
        {
        }

        public DbSet<WebAspNetCore.Models.Department> Department { get; set; }
    }
}
