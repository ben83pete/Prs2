using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using prs.Models;

namespace prs.Models {
    public class PrsDbContext : DbContext {

        public DbSet<User> Users { get; set; }
        public DbSet<prs.Models.Vendor> Vendor { get; set; }
        public DbSet<prs.Models.Product> Product { get; set; }


        public PrsDbContext(DbContextOptions<PrsDbContext> context) : base(context) { }

        protected override void OnModelCreating(ModelBuilder builder) {
            builder.Entity<User>()
                .HasIndex(u => u.Username)
                .IsUnique();

            builder.Entity<Vendor>()
                .HasIndex(v => v.Name)
                .IsUnique();    

            builder.Entity<Product>()
                .HasIndex(p => p.Name)
                .IsUnique();
        }        

        public DbSet<prs.Models.Request> Request { get; set; }

        public DbSet<prs.Models.Request_Lines> Request_Lines { get; set; }
    }
}
