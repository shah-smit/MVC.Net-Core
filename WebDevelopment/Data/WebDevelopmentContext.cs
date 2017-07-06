using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebDevelopment.Models
{
    public class WebDevelopmentContext : DbContext
    {
        public WebDevelopmentContext (DbContextOptions<WebDevelopmentContext> options)
            : base(options)
        {
        }

        public DbSet<WebDevelopment.Models.Movie> Movie { get; set; }
    }
}
