using System;
using Microsoft.EntityFrameworkCore;

namespace DWC.API.Models
{
    public class DWCContext : DbContext
    {
        public DWCContext(DbContextOptions<DWCContext> options)
           : base(options)
        {

        }

        public DbSet<Developer> Developers { get; set; }
        public DbSet<Skill> Skills { get; set; }

    }
}
