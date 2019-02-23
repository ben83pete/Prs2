using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using prs.Models;

namespace prs.Models {
    public class PrsDbContext : DbContext {

        public DbSet<User> Users { get; set; }

        public PrsDbContext(DbContextOptions<PrsDbContext> context) : base(context) { }

        protected override void OnModelCreating(ModelBuilder builder) {
            builder.Entity<User>()
                .HasIndex(u => u.Username)
                .IsUnique();

            builder.Entity<Vendors>()
                .HasIndex(v => v.Name)
                .IsUnique();
        }

        public DbSet<prs.Models.Vendors> Vendors { get; set; }
    }
}
