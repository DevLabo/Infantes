using Infantes.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;

namespace Infantes.Database
{
    public class InfantContext : IdentityDbContext<IdentityUser>
    {
        public InfantContext(DbContextOptions<InfantContext> options) 
            : base(options)
        {

        }

        public DbSet<Infant> Infants { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new InfantConfiguration());

            base.OnModelCreating(builder);
        }
    }
}
