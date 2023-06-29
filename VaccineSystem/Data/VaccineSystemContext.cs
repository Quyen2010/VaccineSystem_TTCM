using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VaccineSystem.Models;

namespace VaccineSystem.Data
{
    public class VaccineSystemContext : DbContext
    {
        public VaccineSystemContext (DbContextOptions<VaccineSystemContext> options)
            : base(options)
        {
        }

        public DbSet<VaccineSystem.Models.User> User { get; set; } = default!;

        public DbSet<VaccineSystem.Models.Brand>? Brand { get; set; }

        public DbSet<VaccineSystem.Models.Category>? Category { get; set; }

        public DbSet<VaccineSystem.Models.Product>? Product { get; set; }
    }
}
