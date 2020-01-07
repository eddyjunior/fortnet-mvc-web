using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Fortnet.Models
{
    public class FortnetContext : DbContext
    {
        public FortnetContext (DbContextOptions<FortnetContext> options)
            : base(options)
        {
        }

        public DbSet<Fortnet.Models.Department> Department { get; set; }
    }
}
