using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewBrandingStyle.Web.Entities;

namespace NewBrandingStyle.Web.Database
{
    public class CompanyDbContext : DbContext
    {
        public CompanyDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<ItemEntity> Items { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
        }
    }
}
