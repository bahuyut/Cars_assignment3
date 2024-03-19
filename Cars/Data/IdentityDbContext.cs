using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cars.Models;

    public class IdentityDbContext : DbContext
    {
        public IdentityDbContext (DbContextOptions<IdentityDbContext> options)
            : base(options)
        {
        }

        public DbSet<Cars.Models.Brand> Brand { get; set; } = default!;

        public DbSet<Cars.Models.Vehicle> Vehicle { get; set; } = default!;
    }
