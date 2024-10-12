using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SalesCRMApp.Models;

namespace SalesCRMApp.Data
{
    public class SalesAppDbContext : IdentityDbContext
    {
        public SalesAppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<SalesLeadEntity> SalesLead { get; set; }

        public DbSet<ApplicationUser> ApplicationUser { get; set; }
    }
}
